using System.Globalization;

class Car
{
    public string Model { get; set; }
    public double FuelAmount { get; set; } // in liters
    public double FuelConsumptionPerKilometer { get; set; } // in liters per km
    public double DistanceTraveled { get; set; } // in kilometers

    public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        DistanceTraveled = 0;
    }

    public void Drive(double distance)
    {
        double fuelNeeded = distance * FuelConsumptionPerKilometer;
        if (fuelNeeded <= FuelAmount)
        {
            DistanceTraveled += distance;
            FuelAmount -= fuelNeeded;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] analyzer = Console.ReadLine().Split();
            string model = analyzer[0];
            double fuelAmount = double.Parse(analyzer[1], CultureInfo.InvariantCulture);
            double fuelConsumptionPerKilometer = double.Parse(analyzer[2], CultureInfo.InvariantCulture);

            Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
            cars.Add(car);
        }

        string input;
        while((input = Console.ReadLine()) != "End")
        {
            string[] commandParts = input.Split();
            string model = commandParts[1];
            double distance = double.Parse(commandParts[2], CultureInfo.InvariantCulture);
            Car car = cars.FirstOrDefault(c => c.Model == model);
            if (car != null)
            {
                car.Drive(distance);
            }
        }

        foreach (Car car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
        }
    }
}