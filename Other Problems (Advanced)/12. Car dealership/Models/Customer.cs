using CarDealership.Models.Contracts;
using CarDealership.Utilities.Messages;

namespace CarDealership.Models
{
    public abstract class Customer : ICustomer
    {
        private string name;
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameIsRequired);
                }
                name = value;
            }
        }

        private List<string> purchases;
        public IReadOnlyCollection<string> Purchases
        {
            get
            {
                return purchases.AsReadOnly();
            }
        }

        public void BuyVehicle(string vehicleModel)
        {
            purchases.Add(vehicleModel);
        }

        public Customer(string name)
        {
            Name = name;
            purchases = new List<string>();
        }

        public override string ToString()
        {
            return $"{Name} - Purchases: {Purchases.Count}";
        }
    }
}
