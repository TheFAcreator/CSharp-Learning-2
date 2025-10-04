namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; protected set; }
        public double FuelConsumption { get; protected set; }

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public void Drive(double distance)
        {
            double neededFuel = distance * this.FuelConsumption;

            if (neededFuel > this.FuelQuantity)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
            else
            {
                this.FuelQuantity -= neededFuel;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
        }

        public abstract void Refuel(double liters);

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
