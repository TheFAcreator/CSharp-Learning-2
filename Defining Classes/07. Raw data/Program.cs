using System.Globalization;

class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
    public Tire[] Tires { get; set; }

    public Car(string model, int speed, int power, string cargoType, int cargoWeight, Tire[] tires)
    {
        Model = model;
        Engine = new Engine { Speed = speed, Power = power };
        Cargo = new Cargo { Type = cargoType, Weight = cargoWeight };
        Tires = tires;
    }
}
class Engine
{
    public int Speed { get; set; }
    public int Power { get; set; }
}
class Cargo
{
    public string Type { get; set; }
    public int Weight { get; set; }
}
class Tire
{
    public int Age { get; set; }
    public double Pressure { get; set; }
}

class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] carInfo = Console.ReadLine().Split();
            string model = carInfo[0];
            int speed = int.Parse(carInfo[1]);
            int power = int.Parse(carInfo[2]);
            int cargoWeight = int.Parse(carInfo[3]);
            string cargoType = carInfo[4];

            Tire[] tires = new Tire[4];
            for (int j = 0; j < 4; j++)
            {
                double pressure = double.Parse(carInfo[5 + j * 2], CultureInfo.InvariantCulture);
                int age = int.Parse(carInfo[6 + j * 2]);
                tires[j] = new Tire { Age = age, Pressure = pressure };
            }

            cars.Add(new Car(model, speed, power, cargoType, cargoWeight, tires));
        }

        string filterType = Console.ReadLine();
        foreach (var car in cars.Where(c => c.Cargo.Type == filterType))
        {
            if (filterType == "flammable" && car.Engine.Power > 250)
            {
                Console.WriteLine(car.Model);
            }
            else if (filterType == "fragile" && car.Tires.Any(t => t.Pressure < 1))
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}