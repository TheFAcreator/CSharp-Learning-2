namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        // Arrange
        private const string make = "Toyota";
        private const string model = "Corolla";
        private const double fuelConsumption = 5.0;
        private const double fuelCapacity = 50.0;

        [Test]
        public void Constructor_ShouldInitializeCarWithCorrectValues()
        {
            // Act
            var car = new Car(make, model, fuelConsumption, fuelCapacity);
            // Assert
            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount); // Initial fuel amount should be 0
        }

        [Test]
        public void Make_ShouldThrowArgumentExceptionWhenSetToNullOrEmpty()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Car(null, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void Model_ShouldThrowArgumentExceptionWhenSetToNullOrEmpty()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Car(make, null, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void FuelConsumption_ShouldThrowArgumentExceptionWhenSetToZeroOrNegative()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Car(make, model, -1, fuelCapacity));
        }

        [Test]
        public void FuelCapacity_ShouldThrowArgumentExceptionWhenSetToZeroOrNegative()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, -1));
        }

        [Test]
        public void Refuel_ShouldIncreaseFuelAmountWhenGivenValidAmount()
        {
            // Arrange
            var car = new Car(make, model, fuelConsumption, fuelCapacity);
            double refuelAmount = 20.0;
            // Act
            car.Refuel(refuelAmount);
            // Assert
            Assert.AreEqual(refuelAmount, car.FuelAmount);
        }

        [Test]
        public void Refuel_ShouldNotExceedFuelCapacity()
        {
            // Arrange
            var car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(30); // Fill the tank partially
            double refuelAmount = 30.0; // Attempt to refuel more than capacity
            // Act
            car.Refuel(refuelAmount);
            // Assert
            Assert.AreEqual(fuelCapacity, car.FuelAmount); // Should not exceed capacity
        }

        [Test]
        public void Refuel_ShouldThrowArgumentExceptionWhenRefuelAmountIsZeroOrNegative()
        {
            // Arrange
            var car = new Car(make, model, fuelConsumption, fuelCapacity);
            // Act & Assert
            Assert.Throws<ArgumentException>(() => car.Refuel(-1));
            Assert.Throws<ArgumentException>(() => car.Refuel(0));
        }

        [Test]
        public void Drive_ShouldDecreaseFuelAmountWhenDriving()
        {
            // Arrange
            var car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(50); // Fill the tank
            double distance = 100; // Distance to drive
            double expectedFuelAmount = 50 - (distance / 100) * fuelConsumption;
            // Act
            car.Drive(distance);
            // Assert
            Assert.AreEqual(expectedFuelAmount, car.FuelAmount);
        }

        [Test]
        public void Drive_ShouldThrowInvalidOperationExceptionWhenFuelAmountIsInsufficient()
        {
            // Arrange
            var car = new Car(make, model, fuelConsumption, fuelCapacity);
            double distance = 100; // Distance to drive
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => car.Drive(distance));
        }
    }
}