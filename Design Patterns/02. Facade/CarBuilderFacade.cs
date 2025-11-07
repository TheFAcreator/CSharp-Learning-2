namespace Façade
{
    public class CarBuilderFaçade
    {
        protected Car Car { get; set; }

        public CarBuilderFaçade()
        {
            Car = new Car();
        }

        public Car Build() => Car;

        public CarInfoBuilder Info => new CarInfoBuilder(Car);
        public CarAddressBuilder Address => new CarAddressBuilder(Car);
    }
}
