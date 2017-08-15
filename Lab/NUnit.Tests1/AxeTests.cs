using System;
using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    // private const int AxeDmg = 10;
    // private const int AxeDur = 1;
    // 
    // private const int DummyHp = 10;
    // private const int DummyXp = 10;
    // 
    // private Axe axe;
    // private Dummy dummy;

    // [SetUp]
    // public void SetEntities()
    // {
    //     axe = new Axe(AxeDmg, AxeDur);
    //     dummy = new Dummy(DummyHp, DummyXp);
    // }

    [Test]
    public void CheckIfWeaponUsesDurability()
    {
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(20, 20);
        axe.Attack(dummy);

        Assert.AreEqual(9, axe.DurabilityPoints);
    }

    [Test]
    public void AttackWithBrokenAxe()
    {
        Axe axe = new Axe(1, 1);
        Dummy dummy = new Dummy(10, 10);

        axe.Attack(dummy);

        var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        Assert.AreEqual("Axe is broken.", ex.Message);
    }
}