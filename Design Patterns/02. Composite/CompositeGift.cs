namespace Composite
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private List<GiftBase> _gifts;

        public CompositeGift(string name, int price) : base(name, price)
        {
            _gifts = new List<GiftBase>();
        }

        public override int CalculatePrice()
        {
            int count = 0;

            Console.WriteLine($"{name} contains following products:");

            foreach (var gift in _gifts)
            {
                count += gift.CalculatePrice();
            }

            return count;
        }

        public void AddGift(GiftBase gift)
        {
            _gifts.Add(gift);
        }

        public void RemoveGift(GiftBase gift)
        {
            _gifts.Remove(gift);
        }
    }
}
