class Car
{
    public string Name { get; set; }
    public int Mileage { get; set; }
    public int Fuel { get; set; }
}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split("|");
            string name = input[0];
            int mileage = int.Parse(input[1]);
            int fuel = int.Parse(input[2]);
            Car car = new Car();
            car.Name = name;
            car.Mileage = mileage;
            car.Fuel = fuel;
            cars.Add(car);
        }
        string input2 = "";
        while ((input2 = Console.ReadLine()) != "Stop")
        {
            string[] command = input2.Split(" : ");
            string action = command[0];
            Car car = cars.Where(x => x.Name == command[1]).FirstOrDefault();
            if (action == "Drive")
            {
                int distance = int.Parse(command[2]);
                if (car.Fuel < int.Parse(command[3])) Console.WriteLine("Not enough fuel to make that ride");
                else
                {
                    car.Fuel -= int.Parse(command[3]);
                    car.Mileage += distance;
                    Console.WriteLine($"{car.Name} driven for {distance} kilometers. {command[3]} liters of fuel consumed.");
                    if (car.Mileage >= 100_000)
                    {
                        Console.WriteLine($"Time to sell the {car.Name}!");
                        cars.Remove(car);
                    }
                }
            }
            else if (action == "Refuel")
            {
                int fuel = int.Parse(command[2]);
                if (car.Fuel + fuel > 75)
                {
                    fuel = 75 - car.Fuel;
                    car.Fuel = 75;
                }
                else
                {
                    car.Fuel += fuel;
                }
                Console.WriteLine($"{car.Name} refueled with {fuel} liters");
            }
            else if (action == "Revert")
            {
                int decreased;
                if (car.Mileage - int.Parse(command[2]) < 10000)
                {
                    car.Mileage = 10000;
                    decreased = car.Mileage - 10000;
                }
                else
                {
                    car.Mileage -= int.Parse(command[2]);
                    decreased = int.Parse(command[2]);
                }
                Console.WriteLine($"{car.Name} mileage decreased by {decreased} kilometers");
            }
        }
        foreach (Car car in cars) Console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
    }
}