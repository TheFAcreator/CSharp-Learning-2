namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        [Test]
        public void Constructor_ShouldInitializeDataCorrectly()
        {
            // Arrange
            Person[] initialData =
            {
                new Person(1, "User1"),
                new Person(2, "User2"),
                new Person(3, "User3")
            };
            // Act
            Database database = new Database(initialData);
            // Assert
            Assert.AreEqual(3, database.Count, "Count must be dynamic.");
        }

        [Test]
        public void Constructor_ShouldThrowExceptionWhenCapacityExceeded()
        {
            // Arrange
            Person[] initialData = new Person[17]; // 17 elements exceeds the capacity of 16
            for (int i = 0; i < 17; i++)
            {
                initialData[i] = new Person(i + 1, $"User{i + 1}");
            }
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Database(initialData), "Capacity must be exactly 16.");
        }

        [Test]
        public void Add_ShouldThrowExceptionWhenUsernameAlreadyExists()
        {
            // Arrange
            Database database = new Database(new Person(1, "User1"));
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(2, "User1")), "There is already user with this username!");
        }

        [Test]
        public void Add_ShouldThrowExceptionWhenIdAlreadyExists()
        {
            // Arrange
            Database database = new Database(new Person(1, "User1"));
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(1, "User2")), "There is already user with this id!");
        }

        [Test]
        public void Add_ShouldThrowExceptionWhenCapacityExceeded()
        {
            // Arrange
            Database database = new Database();
            for (int i = 0; i < 16; i++)
            {
                database.Add(new Person(i + 1, $"User{i}"));
            }
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(0, "s")), "Array's capacity must be exactly 16 integers!");
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
        public void Remove_ShouldDecreaseCountWhenElementIsRemoved()
        {
            // Arrange
            Database database = new Database(new Person(1, "User1"), new Person(2, "User2"));
            // Act
            database.Remove();
            // Assert
            Assert.AreEqual(1, database.Count, "Count should decrease after removal.");
        }

        [Test]
        public void FindByUsername_ShouldReturnCorrectPerson()
        {
            // Arrange
            Database database = new Database(new Person(1, "User1"), new Person(2, "User2"));
            // Act
            Person foundPerson = database.FindByUsername("User1");
            // Assert
            Assert.IsNotNull(foundPerson, "Person should be found by username.");
            Assert.AreEqual("User1", foundPerson.UserName, "Found person should have the correct username.");
        }

        [Test]
        public void FindByUsername_ShouldThrowExceptionWhenUsernameDoesNotExist()
        {
            // Arrange
            Database database = new Database(new Person(1, "User1"));
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.FindByUsername("NonExistentUser"), "No user is present by this username.");
        }

        [Test]
        public void FindByUsername_ShouldThrowExceptionWhenUsernameIsNull()
        {
            // Arrange
            Database database = new Database(new Person(1, "User1"));
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(null), "Username parameter is null!");
        }

        [Test]
        public void FindById_ShouldReturnCorrectPerson()
        {
            // Arrange
            Database database = new Database(new Person(1, "User1"), new Person(2, "User2"));
            // Act
            Person foundPerson = database.FindById(1);
            // Assert
            Assert.IsNotNull(foundPerson, "Person should be found by id.");
            Assert.AreEqual("User1", foundPerson.UserName, "Found person should have the correct username.");
        }

        [Test]
        public void FindById_ShouldThrowExceptionWhenIdDoesNotExist()
        {
            // Arrange
            Database database = new Database(new Person(1, "User1"));
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.FindById(2), "No user is present by this id.");
        }

        [Test]
        public void FindById_ShouldThrowExceptionWhenIdIsNegative()
        {
            // Arrange
            Database database = new Database(new Person(1, "User1"));
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(-1), "Id must be a positive number.");
        }
    }
}