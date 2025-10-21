namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class ArenaTests
    {
        [Test]
        public void Constructor_ShouldInitializeArenaWithEmptyWarriorsList()
        {
            // Arrange & Act
            Arena arena = new Arena();
            // Assert
            Assert.IsNotNull(arena.Warriors);
            Assert.IsEmpty(arena.Warriors);
            Assert.AreEqual(0, arena.Count);
        }

        [Test]
        public void Warriors_ShouldReturnReadOnlyCollectionOfWarriors()
        {
            // Arrange
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Warrior1", 50, 100);
            // Act
            arena.Enroll(warrior);
            // Assert
            Assert.IsInstanceOf<IReadOnlyCollection<Warrior>>(arena.Warriors);
            Assert.Contains(warrior, (List<Warrior>)arena.Warriors);
        }

        [Test]
        public void Count_ShouldReturnNumberOfWarriorsInArena()
        {
            // Arrange
            Arena arena = new Arena();
            Warrior warrior1 = new Warrior("Warrior1", 50, 100);
            Warrior warrior2 = new Warrior("Warrior2", 60, 120);
            // Act
            arena.Enroll(warrior1);
            arena.Enroll(warrior2);
            // Assert
            Assert.AreEqual(2, arena.Count);
        }

        [Test]
        public void Enroll_ShouldAddWarriorToArena()
        {
            // Arrange
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Warrior1", 50, 100);
            // Act
            arena.Enroll(warrior);
            // Assert
            Assert.AreEqual(1, arena.Count);
            Assert.Contains(warrior, (List<Warrior>)arena.Warriors);
        }

        [Test]
        public void Enroll_ShouldThrowInvalidOperationExceptionWhenWarriorIsAlreadyEnrolled()
        {
            // Arrange
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Warrior1", 50, 100);
            arena.Enroll(warrior);
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior), "Warrior is already enrolled for the fights!");
        }

        [Test]
        public void Fight_ShouldThrowInvalidOperationExceptionWhenAttackerOrDefenderDoesNotExist()
        {
            // Arrange
            Arena arena = new Arena();
            Warrior warrior1 = new Warrior("Warrior1", 50, 100);
            Warrior warrior2 = new Warrior("Warrior2", 50, 100);
            arena.Enroll(warrior1);
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Warrior1", "Warrior3"), "There is no fighter with name Warrior3 enrolled for the fights!");
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Warrior3", "Warrior2"), "There is no fighter with name Warrior3 enrolled for the fights!");
        }

        [Test]
        public void Fight_ShouldReduceHPOfDefenderWhenAttackerFights()
        {
            // Arrange
            Arena arena = new Arena();
            Warrior attacker = new Warrior("Attacker", 50, 100);
            Warrior defender = new Warrior("Defender", 30, 100);
            arena.Enroll(attacker);
            arena.Enroll(defender);
            // Act
            arena.Fight("Attacker", "Defender");
            // Assert
            Assert.AreEqual(50, defender.HP); // Defender should have 100 - 50 = 50 HP left
        }
    }
}
