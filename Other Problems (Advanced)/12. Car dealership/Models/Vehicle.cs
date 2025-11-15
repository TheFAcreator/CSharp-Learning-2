using CarDealership.Models.Contracts;
using CarDealership.Utilities.Messages;

namespace CarDealership.Models
{
    public abstract class Vehicle : IVehicle
    {
        private string model;
        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ModelIsRequired);
                }
                model = value;
            }
        }

        private double price;
        public double Price
        {
            get => price;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.PriceMustBePositive);
                }
                price = value;
            }
        }

        private List<string> buyers;
        public IReadOnlyCollection<string> Buyers => buyers.AsReadOnly();

        public int SalesCount => Buyers.Count;

        public void SellVehicle(string buyerName)
        {
            buyers.Add(buyerName);
        }

        public Vehicle(string model, double price)
        {
            Model = model;
            Price = price;
            buyers = new List<string>();
        }

        public override string ToString()
        {
            return $"{Model} - Price: {Price:F2}, Total Model Sales: {SalesCount}";
        }
    }
}
