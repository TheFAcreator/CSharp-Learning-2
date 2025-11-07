namespace Command_pattern
{
    public class Product // Receiver
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void IncreasePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"Price of {Name} increased by {amount}. New price: {Price}");
        }

        public void DecreasePrice(int amount)
        {
            if (amount < Price)
            {
                Price -= amount;
                Console.WriteLine($"Price of {Name} decreased by {amount}. New price: {Price}");
            }
            else
            {
                Console.WriteLine($"Cannot decrease price of {Name} by {amount}. Current price is {Price}.");
            }
        }

        public override string ToString()
        {
            return $"{Name} - {Price}$";
        }
    }
}
