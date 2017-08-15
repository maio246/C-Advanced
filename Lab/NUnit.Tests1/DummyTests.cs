using System;
using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private const int AxeDmg = 11;

    private const int DummyHp = 20;
    private const int DummyXp = 20;

    private Dummy dummy;

    [SetUp]
    public void SetEntities()
    {
        dummy = new Dummy(DummyHp, DummyXp);
    }

    [Test]
    public void DummyLosesHpOnHit()
    {
        dummy.TakeAttack(AxeDmg);

        Assert.AreEqual(9, dummy.Health);
    }

    [Test]
    public void DeadDummyThrowsException()
    {
        dummy = new Dummy(0, 0);

        var ex = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(AxeDmg));

        Assert.AreEqual("Dummy is dead.", ex.Message);
    }

    [Test]
    public void DeadDummyGivesXp()
    {
        dummy = new Dummy(0, 1);

        Assert.AreEqual(1, dummy.GiveExperience());
    }

    [Test]
    public void AliveDummyDoesntGiveXp()
    {
        var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        
            Assert.AreEqual("Target is not dead.", ex.Message);
    }
}