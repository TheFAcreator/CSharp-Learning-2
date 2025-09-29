using NeedForSpeed.Vehicles;
using NeedForSpeed.Vehicles.Cars;
using NeedForSpeed.Vehicles.Motorcycles;
using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car motorcycle = new Car(100, 50);
            motorcycle.Drive(4);
            Console.WriteLine($"Remaining fuel: {motorcycle.Fuel}");
        }
    }
}
