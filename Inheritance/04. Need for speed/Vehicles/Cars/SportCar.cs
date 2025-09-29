namespace NeedForSpeed.Vehicles.Cars
{
    public class SportCar : Car
    {
        public override double FuelConsumption => DefaultFuelConsumption;

        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 10;
        }

        public override void Drive(double kilometers)
        {
            double fuelNeeded = kilometers * FuelConsumption;

            Fuel -= fuelNeeded;
        }
    }
}
