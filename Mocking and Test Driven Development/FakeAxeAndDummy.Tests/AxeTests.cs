[TestFixture]
public class AxeTests
{
    [Test]
    public void Constructor_ShouldInitializeCorrectly()
    {
        // Arrange
        int attackPoints = 10;
        int durabilityPoints = 5;
        // Act
        var axe = new FakeAxeAndDummy.Axe(attackPoints, durabilityPoints);
        // Assert
        Assert.AreEqual(attackPoints, axe.AttackPoints);
        Assert.AreEqual(durabilityPoints, axe.DurabilityPoints);
    }

    [Test]
    public void Attack_ShouldReduceDurability()
    {
        // Arrange
        var axe = new FakeAxeAndDummy.Axe(10, 5);
        var target = new FakeAxeAndDummy.Dummy(10, 10);
        // Act
        axe.Attack(target);
        // Assert
        Assert.AreEqual(4, axe.DurabilityPoints);
    }

    [Test]
    public void Attack_ShouldThrowExceptionWhenDurabilityIsZero()
    {
        // Arrange
        var axe = new FakeAxeAndDummy.Axe(10, 0);
        var target = new FakeAxeAndDummy.Dummy(10, 10);
        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => axe.Attack(target), "Axe is broken.");
    }
}