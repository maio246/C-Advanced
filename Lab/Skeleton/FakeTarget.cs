public class FakeTarget : ITarget
{
    public void TakeAttack(int attackPoints)
    {
    }

    public int Health => 0;
    public int GiveExperience() => 20;

    public bool IsDead()
    {
        return true;
    }
}