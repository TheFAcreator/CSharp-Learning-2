namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        public double FuelQuantity { get => fuelQuantity; 
            protected set 
            {
                if (value > TankCapacity)
                {
                    throw new ArgumentException($"Cannot fit {value - fuelQuantity} fuel in the tank");
                }

                fuelQuantity = value;
            } 
        }

        public double FuelConsumption { get; protected set; }
        public double TankCapacity { get; protected set; }

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;

            if(fuelQuantity > tankCapacity)
            {
                this.FuelQuantity = 0;
            }
            else this.FuelQuantity = fuelQuantity;
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
