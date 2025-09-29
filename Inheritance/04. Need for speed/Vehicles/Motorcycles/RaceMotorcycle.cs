namespace NeedForSpeed.Vehicles.Motorcycles
{
    public class RaceMotorcycle : Motorcycle
    {
        public override double FuelConsumption => DefaultFuelConsumption;

        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 8;
        }

        public override void Drive(double kilometers)
        {
            double fuelNeeded = kilometers * FuelConsumption;

            Fuel -= fuelNeeded;
        }
    }
}
