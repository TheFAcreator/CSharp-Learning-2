namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelConsumption { get; set; } // in liters per 100 km
        public double FuelQuantity { get; set; } // in liters

        public void Drive(double distance)
        {
            double fuelNeeded = distance * FuelConsumption / 100;
            if (!(fuelNeeded < 0))
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= fuelNeeded;
            }
        }

        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}";
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {

        }
    }
}