using System.Collections.Generic;
class Car
{
    public Car(string model, double fuel, double fpk)
    {
        Model = model;
        Fuel = fuel;
        FPK = fpk;
        DistanceTraveled = 0;
    }
    public string Model { get; set; }
    public double Fuel { get; set; }
    public double FPK { get; set; }
    public int DistanceTraveled { get; set; }
    public bool IsFuelSufficient(int km)
    {
        if (Fuel - km * FPK >= 0) return true;
        Console.WriteLine("Insufficient fuel for the drive");
        return false;
    }
}
class Program
{
    static void Main()
    {
        List<Car> cars = new();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] analyzer = Console.ReadLine().Split();
            cars.Add(new Car(analyzer[0], double.Parse(analyzer[1]), double.Parse(analyzer[2])));
        }
        string input = "";
        while ((input = Console.ReadLine()) != "End")
        {
            string[] analyzer = input.Split();
            var car = cars.FirstOrDefault(h => h.Model == analyzer[1]);
            if (car.IsFuelSufficient(int.Parse(analyzer[2])))
            {
                car.Fuel -= int.Parse(analyzer[2]) * car.FPK;
                car.DistanceTraveled += int.Parse(analyzer[2]);
            }
        }
        foreach (Car car in cars)
            Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.DistanceTraveled}");
    }
}