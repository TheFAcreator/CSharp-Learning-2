namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption + 1.6, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            try
            {
                FuelQuantity += liters;
                // If tank capacity is exceeded, an exception will be thrown

                FuelQuantity -= liters;
                FuelQuantity += liters * 0.95; // Trucks can only take 95% of the fuel
            }
            catch (ArgumentException)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
        }
    }
}
