using CarDealership.Models.Contracts;
using CarDealership.Repositories.Contracts;

namespace CarDealership.Repositories
{
    public class VehicleRepository : IRepository<IVehicle>
    {
        private List<IVehicle> vehicles = new();
        public IReadOnlyCollection<IVehicle> Models
        {
            get
            {
                return vehicles.AsReadOnly();
            }
        }

        public void Add(IVehicle model)
        {
            vehicles.Add(model);
        }

        public bool Exists(string text)
        {
            return vehicles.Any(v => v.Model == text);
        }

        public IVehicle Get(string text)
        {
            return vehicles.FirstOrDefault(v => v.Model == text);
        }

        public bool Remove(string text)
        {
            var vehicle = Get(text);

            if (vehicle != null)
            {
                vehicles.Remove(vehicle);
                return true;
            }
            return false;
        }
    }
}
