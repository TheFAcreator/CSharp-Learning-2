using CarDealership.Models.Contracts;
using CarDealership.Repositories.Contracts;

namespace CarDealership.Repositories
{
    public class CustomerRepository : IRepository<ICustomer>
    {
        private List<ICustomer> customers = new();
        public IReadOnlyCollection<ICustomer> Models
        {
            get
            {
                return customers.AsReadOnly();
            }
        }

        public void Add(ICustomer model)
        {
            customers.Add(model);
        }

        public bool Exists(string text)
        {
            return customers.Any(v => v.Name == text);
        }

        public ICustomer Get(string text)
        {
            return customers.FirstOrDefault(v => v.Name == text);
        }

        public bool Remove(string text)
        {
            var customer = Get(text);

            if (customer != null)
            {
                customers.Remove(customer);
                return true;
            }
            return false;
        }
    }
}
