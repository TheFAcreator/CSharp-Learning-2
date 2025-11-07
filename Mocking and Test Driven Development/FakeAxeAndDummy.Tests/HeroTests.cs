using FakeAxeAndDummy;
using Moq;

[TestFixture]
public class HeroTests
{
    [Test]
    public void HeroGainsExperienceAfterAttackingTarget()
    {
        //Without Mocking
        //// Arrange
        //var weapon = new FakeAxeAndDummy.Axe(10, 10);
        //var target = new FakeAxeAndDummy.Dummy(10, 10);
        //var hero = new FakeAxeAndDummy.Hero("Hero", 0, weapon);
        //// Act
        //hero.Attack(target);
        //// Assert
        //Assert.AreEqual(10, hero.Experience);


        //With Mocking
        //Arrange
        Mock<IWeapon> weaponMock = new();
        weaponMock.Setup(w => w.Attack(It.IsAny<ITarget>()));

        Mock<ITarget> targetMock = new();
        targetMock.Setup(t => t.IsDead()).Returns(true);
        targetMock.Setup(t => t.GiveExperience()).Returns(10);

        var hero = new Hero("Hero", weaponMock.Object);
        // Act
        hero.Attack(targetMock.Object);
        // Assert
        Assert.AreEqual(10, hero.Experience);
    }
}
