class Box<T>
{
    public T Value { get; set; }
    public Box(T value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return $"{typeof(T)}: {Value}";
    }
}
class Program
{
    static void Swap<T>(List<T> list, int ind1, int ind2)
    {
        (list[ind1], list[ind2]) = (list[ind2], list[ind1]);

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Box<string>> boxes = new();
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            boxes.Add(new Box<string>(input));
        }

        string[] analyzer = Console.ReadLine().Split();
        int ind1 = int.Parse(analyzer[0]);
        int ind2 = int.Parse(analyzer[1]);

        Swap(boxes, ind1, ind2);
    }
}