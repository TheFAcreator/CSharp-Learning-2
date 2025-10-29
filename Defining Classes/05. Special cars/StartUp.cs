namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire> tires = new List<Tire>();

            string input;
            while((input = Console.ReadLine()) != "No more tires")
            {
                string[] tireData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int year = int.Parse(tireData[0]); double pressure = double.Parse(tireData[1]);
                int year2 = int.Parse(tireData[2]); double pressure2 = double.Parse(tireData[3]);
                int year3 = int.Parse(tireData[4]); double pressure3 = double.Parse(tireData[5]);
                int year4 = int.Parse(tireData[6]); double pressure4 = double.Parse(tireData[7]);

                tires.Add(new Tire(year, pressure));
                tires.Add(new Tire(year2, pressure2));
                tires.Add(new Tire(year3, pressure3));
                tires.Add(new Tire(year4, pressure4));
            }

            List<Engine> engines = new List<Engine>();
            while((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(engineData[0]);
                double cubicCapacity = double.Parse(engineData[1]);
                engines.Add(new Engine(horsePower, cubicCapacity));
            }

            List<Car> cars = new List<Car>();
            while((input = Console.ReadLine()) != "Show special")
            {
                string[] carData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string make = carData[0];
                string model = carData[1];
                int year = int.Parse(carData[2]);
                double fuelQuantity = double.Parse(carData[3]);
                double fuelConsumption = double.Parse(carData[4]);
                int engineIndex = int.Parse(carData[5]);
                Tire[] carTires = tires.Skip(int.Parse(carData[6]) * 4).Take(4).ToArray();

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], carTires));
            }

            List<Car> specialCars = cars.Where(c => c.Year >= 2017 && c.Engine.HorsePower > 330 && c.Tires.Sum(t => t.Pressure) >= 9 && c.Tires.Sum(t => t.Pressure) <= 10).ToList();
            foreach (Car car in specialCars)
            {
                car.Drive(20);

                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}