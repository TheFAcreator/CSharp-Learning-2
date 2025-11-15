namespace AutoTrade.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    [TestFixture]
    public class DealerShopTests
    {
        // Arrange
        DealerShop dealerShop;
        [SetUp]
        public void Setup()
        {
            dealerShop = new(5);
        }

        [Test]
        public void Constructor_ShouldInitializeCorrectly()
        {
            // Assert
            Assert.AreEqual(5, dealerShop.Capacity);
        }

        [Test]
        public void Capacity_ShouldThrowExceptionWhenSetToZeroOrNegative()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new DealerShop(0));
            Assert.Throws<ArgumentException>(() => new DealerShop(-1));
        }

        [Test]
        public void Vehicles_ShouldReturnReadOnlyCollection()
        {
            // Act
            var vehicles = dealerShop.Vehicles;
            // Assert
            Assert.That(vehicles, Is.InstanceOf<IReadOnlyCollection<Vehicle>>());
        }

        [Test]
        public void AddVehicle_ShouldAddVehicleWhenCapacityAllows()
        {
            // Arrange
            var vehicle = new Vehicle("Toyota", "Corolla", 2020);
            // Act
            var result = dealerShop.AddVehicle(vehicle);
            // Assert
            Assert.AreEqual($"Added {vehicle}", result);
            Assert.Contains(vehicle, dealerShop.Vehicles.ToList());
        }

        [Test]
        public void AddVehicle_ShouldThrowExceptionWhenCapacityIsFull()
        {
            // Arrange
            for (int i = 0; i < 5; i++)
            {
                dealerShop.AddVehicle(new Vehicle($"Make{i}", $"Model{i}", 2000 + i));
            }
            var newVehicle = new Vehicle("Honda", "Civic", 2021);
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => dealerShop.AddVehicle(newVehicle));
        }

        [Test]
        public void SellVehicle_ShouldRemoveVehicleWhenExists()
        {
            // Arrange
            var vehicle = new Vehicle("Ford", "Focus", 2019);
            dealerShop.AddVehicle(vehicle);
            // Act
            var result = dealerShop.SellVehicle(vehicle);
            // Assert
            Assert.IsTrue(result);
            Assert.IsFalse(dealerShop.Vehicles.Contains(vehicle));
        }

        [Test]
        public void SellVehicle_ShouldReturnFalseWhenVehicleDoesNotExist()
        {
            // Arrange
            var vehicle = new Vehicle("BMW", "X5", 2021);
            // Act
            var result = dealerShop.SellVehicle(vehicle);
            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void InventoryReport_ShouldReturnCorrectReport()
        {
            // Arrange
            var vehicle1 = new Vehicle("Audi", "A4", 2020);
            var vehicle2 = new Vehicle("Mercedes", "C-Class", 2021);
            dealerShop.AddVehicle(vehicle1);
            dealerShop.AddVehicle(vehicle2);
            // Act
            var report = dealerShop.InventoryReport();
            // Assert
            StringBuilder expectedReport = new StringBuilder();
            expectedReport.AppendLine("Inventory Report");
            expectedReport.AppendLine($"Capacity: {dealerShop.Capacity}");
            expectedReport.AppendLine($"Vehicles: 2");
            expectedReport.AppendLine(vehicle1.ToString());
            expectedReport.AppendLine(vehicle2.ToString());
            Assert.AreEqual(expectedReport.ToString().TrimEnd(), report.TrimEnd());
        }
    }
}
