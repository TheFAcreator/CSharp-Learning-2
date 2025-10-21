namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void Constructor_ShouldInitializeDataCorrectly()
        {
            // Arrange
            int[] initialData = { 1, 2, 3, 4, 5 };
            Database database = new Database(initialData);
            // Act
            int count = database.Count;
            // Assert
            Assert.AreEqual(5, count);
        }

        [Test]
        public void Constructor_ShouldThrowExceptionWhenCapacityExceeded()
        {
            // Arrange
            int[] initialData = new int[17]; // 17 elements exceeds the capacity of 16
            for (int i = 0; i < 17; i++)
            {
                initialData[i] = i + 1;
            }
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => new Database(initialData));
        }

        [Test]
        public void Add_ShouldIncreaseCountWhenElementIsAdded()
        {
            // Arrange
            Database database = new Database();
            // Act
            database.Add(1);
            // Assert
            Assert.AreEqual(1, database.Count);
        }

        [Test]
        public void Add_ShouldThrowExceptionWhenCapacityExceeded()
        {
            // Arrange
            Database database = new Database();
            for (int i = 0; i < 16; i++)
            {
                database.Add(i + 1);
            }
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(17));
        }

        [Test]
        public void Remove_ShouldDecreaseCountWhenElementIsRemoved()
        {
            // Arrange
            Database database = new Database(1, 2, 3);
            // Act
            database.Remove();
            // Assert
            Assert.AreEqual(2, database.Count);
        }

        [Test]
        public void Remove_ShouldRemoveLastElement()
        {
            // Arrange
            Database database = new Database(1, 2, 3);
            // Act
            database.Remove();
            int[] data = database.Fetch();
            // Assert
            Assert.AreEqual(2, data[data.Length - 1]);
        }

        [Test]
        public void Remove_ShouldThrowExceptionWhenCollectionIsEmpty()
        {
            // Arrange
            Database database = new Database();
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void Fetch_ShouldReturnCorrectDataArray()
        {
            // Arrange
            Database database = new Database(1, 2, 3);
            // Act
            int[] data = database.Fetch();
            // Assert
            Assert.AreEqual(3, data.Length);
            Assert.AreEqual(1, data[0]);
            Assert.AreEqual(2, data[1]);
            Assert.AreEqual(3, data[2]);
        }
    }
}
