using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(5, 5);

            axe.Attack(dummy);

            Assert.That(dummy.Health, Is.EqualTo(5), "Dummy should lose health when attacked.");
        }

        [Test]
        public void DeadDummyThrowsExceptionWhenAttacked()
        {
            Dummy dummy = new Dummy(0, 10);

            Axe axe = new Axe(5, 5);

            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy), "Dummy is dead.");
        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            Dummy dummy = new Dummy(0, 10);

            int experience = dummy.GiveExperience();

            Assert.That(experience, Is.EqualTo(10), "Dead dummy should give experience.");
        }

        [Test]
        public void AliveDummyCannotGiveExperience()
        {
            Dummy dummy = new Dummy(10, 10);

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience(), "Target is not dead.");
        }
    }
}