namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private int money;
        private List<Product> products;

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public int Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

        public List<Product> Products
        {
            get => products;
            set => products = value;
        }

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
        }
    }
}
