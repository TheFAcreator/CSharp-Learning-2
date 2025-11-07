namespace FakeAxeAndDummy
{
    public class Axe : IWeapon
    {
        public Axe(int ap, int dp)
        {
            this.AttackPoints = ap;
            this.DurabilityPoints = dp;
        }

        public int AttackPoints { get; set; }

        public int DurabilityPoints { get; set; }

        public void Attack(ITarget target)
        {
            if (this.DurabilityPoints <= 0)
            {
                throw new InvalidOperationException("Axe is broken.");
            }

            target.TakeAttack(this.AttackPoints);
            this.DurabilityPoints -= 1;
        }
    }
}