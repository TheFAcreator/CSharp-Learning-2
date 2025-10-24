class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}
class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}
class Catalog
{
    public static System.Collections.Generic.List<Truck> Trucks { get; set; } = new();
    public static System.Collections.Generic.List<Car> Cars { get; set; } = new();
}
class Program
{
    static void Main()
    {
        string input = "";
        while ((input = Console.ReadLine()) != "end")
        {
            string[] analyzer = input.Split("/");
            if (analyzer[0] == "Car") Catalog.Cars.Add(new Car() { Brand = analyzer[1], Model = analyzer[2], HorsePower = int.Parse(analyzer[3]) });
            else Catalog.Trucks.Add(new Truck() { Brand = analyzer[1], Model = analyzer[2], Weight = int.Parse(analyzer[3]) });
        }
        Console.WriteLine("Cars:");
        var sortedCars = Catalog.Cars.OrderBy(n => n.Brand).ToList();
        foreach (Car car in sortedCars) Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
        if (Catalog.Trucks.Count != 0)
        {
            Console.WriteLine("Trucks:");
            var sortedTrucks = Catalog.Trucks.OrderBy(n => n.Brand).ToList();
            foreach (Truck truck in sortedTrucks) Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
        }
    }
}