namespace Restaurant
{
    public abstract class Beverage : Product
    {
        public double Milliliters { get; set; }

        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            Milliliters = milliliters;
        }
    }
}
