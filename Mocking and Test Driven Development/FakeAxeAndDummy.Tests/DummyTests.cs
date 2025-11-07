[TestFixture]
public class DummyTests
{
    [Test]
    public void Constructor_ShouldInitializeCorrectly()
    {
        // Arrange
        int health = 0;
        int experience = 5;
        // Act
        var dummy = new Dummy(health, experience);
        // Assert
        Assert.AreEqual(health, dummy.Health);
        Assert.AreEqual(experience, dummy.GiveExperience());
    }

    [Test]
    public void TakeAttack_ShouldReduceHealth()
    {
        // Arrange
        var dummy = new Dummy(10, 5);
        // Act
        dummy.TakeAttack(3);
        // Assert
        Assert.AreEqual(7, dummy.Health);
    }

    [Test]
    public void TakeAttack_ShouldThrowExceptionWhenDummyIsDead()
    {
        // Arrange
        var dummy = new Dummy(0, 5);
        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(3), "Dummy is dead.");
    }

    [Test]
    public void GiveExperience_ShouldReturnExperienceWhenDummyIsDead()
    {
        // Arrange
        var dummy = new Dummy(0, 5);
        // Act
        int experience = dummy.GiveExperience();
        // Assert
        Assert.AreEqual(5, experience);
    }

    [Test]
    public void GiveExperience_ShouldThrowExceptionWhenDummyIsAlive()
    {
        // Arrange
        var dummy = new Dummy(10, 5);
        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience(), "Target is not dead.");
    }

    [Test]
    public void IsDead_ShouldReturnTrueWhenHealthIsZeroOrLess()
    {
        // Arrange
        var dummy = new Dummy(0, 5);
        // Act
        bool isDead = dummy.IsDead();
        // Assert
        Assert.IsTrue(isDead);
    }

    [Test]
    public void IsDead_ShouldReturnFalseWhenHealthIsGreaterThanZero()
    {
        // Arrange
        var dummy = new Dummy(10, 5);
        // Act
        bool isDead = dummy.IsDead();
        // Assert
        Assert.IsFalse(isDead);
    }
}
