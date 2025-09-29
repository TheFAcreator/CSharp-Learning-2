namespace NeedForSpeed.Vehicles
{
    public class Car : Vehicle
    {
        public override double FuelConsumption => DefaultFuelConsumption;

        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 3;
        }

        public override void Drive(double kilometers)
        {
            double fuelNeeded = kilometers * FuelConsumption;

            Fuel -= fuelNeeded;
        }
    }
}
