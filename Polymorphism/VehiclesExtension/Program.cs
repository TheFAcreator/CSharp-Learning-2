namespace Vehicles;

public class StartUp
{
    static void Main(string[] args)
    {   
        string[] analyzer = Console.ReadLine().Split();
        Car car = new Car(double.Parse(analyzer[1]), double.Parse(analyzer[2]), double.Parse(analyzer[3]));

        analyzer = Console.ReadLine().Split();
        Truck truck = new Truck(double.Parse(analyzer[1]), double.Parse(analyzer[2]), double.Parse(analyzer[3]));

        analyzer = Console.ReadLine().Split();
        Bus bus = new Bus(double.Parse(analyzer[1]), double.Parse(analyzer[2]), double.Parse(analyzer[3]));

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            analyzer = Console.ReadLine().Split();
            string action = analyzer[0];
            string vehicleType = analyzer[1];
            double value = double.Parse(analyzer[2]);
            try
            {
                if (action == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        car.Drive(value);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Drive(value);
                    }
                    else if (vehicleType == "Bus")
                    {
                        bus.Drive(value, false);
                    }
                }
                else if (action == "Refuel")
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(value);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(value);
                    }
                    else if (vehicleType == "Bus")
                    {
                        bus.Refuel(value);
                    }
                }
                else if (action == "DriveEmpty")
                {
                    bus.Drive(value, true);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }
}