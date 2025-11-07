namespace Composite
{
    public class SingleGift : GiftBase
    {
        public SingleGift(string name, int price) : base(name, price)
        {
        }

        public override int CalculatePrice()
        {
            Console.WriteLine($"{name} costs {price}.");

            return price;
        }
    }
}
