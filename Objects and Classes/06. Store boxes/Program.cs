class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
}
class Box
{
    public int SerialNumber { get; set; }
    public Item Item1 { get; set; }
    public int Quantity { get; set; }
    public double PriceBox
    {
        get
        {
            return Quantity * Item1.Price;
        }
    }
}
class Program
{
    static void Main()
    {
        string input = "";
        System.Collections.Generic.List<Box> boxes = new();
        while ((input = Console.ReadLine()) != "end")
        {
            string[] analyzer = input.Split();
            Box newBox = new() { SerialNumber = int.Parse(analyzer[0]), Item1 = new Item() { Name = analyzer[1], Price = double.Parse(analyzer[3]) }, Quantity = int.Parse(analyzer[2]) };
            boxes.Add(newBox);
        }
        var sortedList = boxes.OrderBy(n => n.PriceBox).ToList();
        sortedList.Reverse();
        foreach (Box box in sortedList)
        {
            Console.WriteLine($"{box.SerialNumber}");
            Console.WriteLine($"-- {box.Item1.Name} - ${box.Item1.Price:f2}: {box.Quantity}");
            Console.WriteLine($"-- ${box.PriceBox:f2}");
        }
    }
}