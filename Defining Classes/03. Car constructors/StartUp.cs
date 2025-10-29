namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            string year = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car car3 = new Car();
            Car car2 = new Car(make, model, int.Parse(year));
            Car car = new Car(make, model, int.Parse(year), fuelQuantity, fuelConsumption);
        }
    }
}