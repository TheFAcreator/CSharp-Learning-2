using CarDealership.Core.Contracts;
using CarDealership.Models;
using CarDealership.Models.Contracts;
using CarDealership.Utilities.Messages;
using System.Text;

namespace CarDealership.Core
{
    public class Controller : IController
    {
        private IDealership dealership = new Dealership();

        public string AddCustomer(string customerTypeName, string customerName)
        {
            if (customerTypeName != nameof(IndividualClient) && customerTypeName != nameof(LegalEntityCustomer))
            {
                return string.Format(OutputMessages.InvalidType, customerTypeName);
            }
            if (dealership.Customers.Exists(customerName))
            {
                return string.Format(OutputMessages.CustomerAlreadyAdded, customerName);
            }

            ICustomer customer;
            if (customerTypeName == nameof(IndividualClient))
            {
                customer = new IndividualClient(customerName);
            }
            else
            {
                customer = new LegalEntityCustomer(customerName);
            }

            dealership.Customers.Add(customer);
            return string.Format(OutputMessages.CustomerAddedSuccessfully, customerName);
        }

        public string AddVehicle(string vehicleTypeName, string model, double price)
        {
            if (vehicleTypeName != nameof(SaloonCar) && vehicleTypeName != nameof(SUV) && vehicleTypeName != nameof(Truck))
            {
                return string.Format(OutputMessages.InvalidType, vehicleTypeName);
            }
            if (dealership.Vehicles.Exists(model))
            {
                return string.Format(OutputMessages.VehicleAlreadyAdded, model);
            }

            IVehicle vehicle;
            if (vehicleTypeName == nameof(SaloonCar))
            {
                vehicle = new SaloonCar(model, price);
            }
            else if (vehicleTypeName == nameof(SUV))
            {
                vehicle = new SUV(model, price);
            }
            else // Truck
            {
                vehicle = new Truck(model, price);
            }

            dealership.Vehicles.Add(vehicle);
            return string.Format(OutputMessages.VehicleAddedSuccessfully, vehicleTypeName, model, $"{vehicle.Price:f2}");
        }

        public string CustomerReport()
        {
            StringBuilder result = new();
            result.AppendLine("Customer Report:");

            foreach (var customer in dealership.Customers.Models.OrderBy(c => c.Name))
            {
                result.AppendLine(customer.ToString());
                result.AppendLine("-Models:");
                if (customer.Purchases.Any())
                {
                    foreach (var purchase in customer.Purchases.OrderBy(p => p))
                    {
                        result.AppendLine($"--{purchase}");
                    }
                }
                else
                {
                    result.AppendLine("--none");
                }
            }
            return result.ToString().TrimEnd();
        }

        public string PurchaseVehicle(string vehicleTypeName, string customerName, double budget)
        {
            if (!dealership.Customers.Exists(customerName))
            {
                return string.Format(OutputMessages.CustomerNotFound, customerName);
            }
            if (vehicleTypeName != nameof(Truck) && vehicleTypeName != nameof(SaloonCar) && vehicleTypeName != nameof(SUV))
            {
                return string.Format(OutputMessages.VehicleTypeNotFound, vehicleTypeName);
            }
            if (!dealership.Vehicles.Models.Any(c => (c is SaloonCar && vehicleTypeName == nameof(SaloonCar))
                || (c is SUV && vehicleTypeName == nameof(SUV))
                || (c is Truck && vehicleTypeName == nameof(Truck))))
            {
                return string.Format(OutputMessages.VehicleTypeNotFound, vehicleTypeName);
            }

            ICustomer customer = dealership.Customers.Get(customerName);
            if ((customer is IndividualClient && vehicleTypeName == nameof(Truck))
                || (customer is LegalEntityCustomer && vehicleTypeName == nameof(SaloonCar)))
            {
                return string.Format(OutputMessages.CustomerNotEligibleToPurchaseVehicle, customerName, vehicleTypeName);
            }

            var availableVehicles = dealership.Vehicles.Models
                .Where(v =>
                    ((vehicleTypeName == nameof(SaloonCar) && v is SaloonCar) ||
                    (vehicleTypeName == nameof(SUV) && v is SUV) ||
                    (vehicleTypeName == nameof(Truck) && v is Truck))
                    && v.Price <= budget) // group by type and price
                .ToList();

            if (!availableVehicles.Any())
            {
                return string.Format(OutputMessages.BudgetIsNotEnough, customerName, vehicleTypeName);
            }

            var vehicle = availableVehicles.OrderByDescending(v => v.Price).First();
            customer.BuyVehicle(vehicle.Model);
            vehicle.SellVehicle(customerName);

            return string.Format(OutputMessages.VehiclePurchasedSuccessfully, customerName, vehicle.Model);
        }

        public string SalesReport(string vehicleTypeName)
        {
            StringBuilder result = new();
            result.AppendLine($"{vehicleTypeName} Sales Report:");

            var vehicles = dealership.Vehicles.Models
                .Where(v =>
                    (vehicleTypeName == nameof(SaloonCar) && v is SaloonCar) ||
                    (vehicleTypeName == nameof(SUV) && v is SUV) ||
                    (vehicleTypeName == nameof(Truck) && v is Truck)); // group by type

            foreach (var vehicle in vehicles.OrderBy(v => v.Model))
            {
                result.AppendLine("--" + vehicle.ToString());
            }
            result.AppendLine($"-Total Purchases: {vehicles.Sum(v => v.SalesCount)}");

            return result.ToString().TrimEnd();
        }
    }
}
