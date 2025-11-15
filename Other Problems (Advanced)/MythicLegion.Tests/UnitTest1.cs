using MythicLegion;

// These tests cover 91/100 of the functionality of the Legion class
namespace MythicLegionTests
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class LegionTests
    {
        private Legion legion;
        private Hero hero1;
        private Hero hero2;

        [SetUp]
        public void Setup()
        {
            legion = new Legion();
            hero1 = new Hero("Arthas", "Warrior");
            hero2 = new Hero("Jaina", "Mage");
        }

        [Test]
        public void AddHero_ShouldAddHeroSuccessfully()
        {
            legion.AddHero(hero1);
            string info = legion.GetLegionInfo();
            Assert.IsTrue(info.Contains("Arthas"));
        }

        [Test]
        public void AddHero_ShouldThrowException_WhenHeroIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => legion.AddHero(null));
        }

        [Test]
        public void AddHero_ShouldThrowException_WhenHeroWithSameNameExists()
        {
            legion.AddHero(hero1);
            var duplicateHero = new Hero("Arthas", "Paladin");
            Assert.Throws<ArgumentException>(() => legion.AddHero(duplicateHero));
        }

        [Test]
        public void RemoveHero_ShouldReturnTrue_WhenHeroExists()
        {
            legion.AddHero(hero1);
            bool result = legion.RemoveHero("Arthas");
            Assert.IsTrue(result);
        }

        [Test]
        public void RemoveHero_ShouldReturnFalse_WhenHeroDoesNotExist()
        {
            bool result = legion.RemoveHero("NonExistent");
            Assert.IsFalse(result);
        }

        [Test]
        public void TrainHero_ShouldIncreaseStats_AndSetIsTrained()
        {
            legion.AddHero(hero1);
            string result = legion.TrainHero("Arthas");

            Assert.AreEqual("Arthas has been trained.", result);
            Assert.AreEqual(30, hero1.Power);
            Assert.AreEqual(101, hero1.Health);
            Assert.IsTrue(hero1.IsTrained);
        }

        [Test]
        public void TrainHero_ShouldReturnMessage_WhenHeroNotFound()
        {
            string result = legion.TrainHero("Unknown");
            Assert.AreEqual("Hero with name Unknown not found.", result);
        }

        [Test]
        public void GetLegionInfo_ShouldReturnMessage_WhenNoHeroes()
        {
            string info = legion.GetLegionInfo();
            Assert.AreEqual("No heroes in the legion.", info);
        }

        [Test]
        public void GetLegionInfo_ShouldReturnHeroInfo_WhenHeroesExist()
        {
            legion.AddHero(hero1);
            legion.AddHero(hero2);

            string info = legion.GetLegionInfo();

            Assert.IsTrue(info.Contains("Arthas"));
            Assert.IsTrue(info.Contains("Jaina"));
            Assert.IsTrue(info.Contains("Power: 20"));
        }

        [Test]
        public void TrainHero_ShouldOnlyAffectCorrectHero()
        {
            var anotherHero = new Hero("Thrall", "Shaman");

            legion.AddHero(hero1); // Arthas
            legion.AddHero(anotherHero); // Thrall

            legion.TrainHero("Arthas");

            Assert.IsTrue(hero1.IsTrained);
            Assert.AreEqual(101, hero1.Health);
            Assert.AreEqual(30, hero1.Power);

            Assert.IsFalse(anotherHero.IsTrained);
            Assert.AreEqual(100, anotherHero.Health);
            Assert.AreEqual(20, anotherHero.Power);
        }
    }
}
