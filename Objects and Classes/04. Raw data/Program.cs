public class Car
{
    public Car(string model, int speed, int power, int weight, string type)
    {
        Model = model;
        Engine = new Engine { Speed = speed, Power = power };
        Cargo = new Cargo { Weight = weight, Type = type };
    }
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
}
public class Engine
{
    public int Speed { get; set; }
    public int Power { get; set; }
}
public class Cargo
{
    public int Weight { get; set; }
    public string Type { get; set; }
}
public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        for (int i = 0; i < n; i++)
        {
            string[] analyzer = Console.ReadLine().Split();
            string model = analyzer[0];
            int speed = int.Parse(analyzer[1]);
            int power = int.Parse(analyzer[2]);
            int weight = int.Parse(analyzer[3]);
            string type = analyzer[4];
            Car car = new Car(model, speed, power, weight, type);
            cars.Add(car);
        }
        string filter = Console.ReadLine();
        if (filter == "fragile")
        {
            foreach (var car in cars)
            {
                if (car.Cargo.Type == "fragile" && car.Cargo.Weight < 1000)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
        else if (filter == "flamable")
        {
            foreach (var car in cars)
            {
                if (car.Cargo.Type == "flamable" && car.Engine.Power > 250)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}