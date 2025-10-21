namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        // Arrange
        private const string name = "Warrior1";
        private const int damage = 50;
        private const int hp = 100;

        [Test]
        public void Constructor_ShouldInitializeWarriorWithCorrectValues()
        {
            // Act
            Warrior warrior = new Warrior(name, damage, hp);
            // Assert
            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(damage, warrior.Damage);
            Assert.AreEqual(hp, warrior.HP);
        }

        [Test]
        public void Constructor_ShouldThrowArgumentExceptionWithInvalidValues()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Warrior(null, damage, hp), "Name should not be empty or whitespace!");
            Assert.Throws<ArgumentException>(() => new Warrior("   ", damage, hp), "Name should not be empty or whitespace!");
            Assert.Throws<ArgumentException>(() => new Warrior(name, -10, hp), "Damage value should be positive!");
            Assert.Throws<ArgumentException>(() => new Warrior(name, 0, hp), "Damage value should be positive!");
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, -10), "HP should not be negative!");
        }

        [Test]
        public void Name_ShouldThrowArgumentExceptionWhenSetToNullOrEmpty()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Warrior(null, damage, hp));
            Assert.Throws<ArgumentException>(() => new Warrior("   ", damage, hp));
        }

        [Test]
        public void Name_ShouldInitializeCorrectlyWhenSetToValidValue()
        {
            // Act
            Warrior warrior = new Warrior(name, damage, hp);
            // Assert
            Assert.AreEqual(name, warrior.Name);
        }

        [Test]
        public void Damage_ShouldThrowArgumentExceptionWhenSetToZeroOrNegative()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Warrior(name, -10, hp));
            Assert.Throws<ArgumentException>(() => new Warrior(name, 0, hp));
        }

        [Test]
        public void Damage_ShouldInitializeCorrectlyWhenSetToValidValue()
        {
            // Act
            Warrior warrior = new Warrior(name, damage, hp);
            // Assert
            Assert.AreEqual(damage, warrior.Damage);
        }

        [Test]
        public void HP_ShouldThrowArgumentExceptionWhenSetToNegative()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, -10));
        }

        [Test]
        public void HP_ShouldInitializeCorrectlyWhenSetToValidValue()
        {
            // Act
            Warrior warrior = new Warrior(name, damage, hp);
            // Assert
            Assert.AreEqual(hp, warrior.HP);
        }

        [Test]
        public void Attack_ShouldThrowInvalidOperationExceptionWhenHpIsTooLow()
        {
            // Arrange
            Warrior warrior = new Warrior(name, damage, 30);
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(null));
        }

        [Test]
        public void Attack_ShouldThrowInvalidOperationExceptionWhenEnemyHpIsTooLow()
        {
            // Arrange
            Warrior warrior = new Warrior(name, damage, hp);
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(new Warrior("Enemy", damage, 30)));
        }

        [Test]
        public void Attack_ShouldThrowInvalidOperationExceptionWhenEnemyHpIsGreater()
        {
            // Arrange
            Warrior warrior = new Warrior(name, damage, hp);
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(new Warrior("Enemy", hp + 1, hp)));
        }

        [Test]
        public void Attack_ShouldReduceEnemyHpCorrectly()
        {
            // Arrange
            Warrior warrior = new Warrior(name, damage, hp);
            Warrior enemy = new Warrior("Enemy", damage, hp);
            int expectedHp = enemy.HP - warrior.Damage;
            // Act
            warrior.Attack(enemy);
            // Assert
            Assert.AreEqual(expectedHp, enemy.HP);
        }

        [Test]
        public void Attack_EnemyHpShouldNotFallBelowZero()
        {
            // Arrange
            Warrior warrior = new Warrior(name, damage, hp);
            Warrior enemy = new Warrior("Enemy", damage, 40);
            // Act
            warrior.Attack(enemy);
            // Assert
            Assert.AreEqual(enemy.HP, 0, "Enemy HP should not fall below zero after attack.");
        }
    }
}