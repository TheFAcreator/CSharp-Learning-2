namespace FakeAxeAndDummy
{
    internal class Dummy : ITarget
    {
        public Dummy(int h, int experience)
        {
            this.Health = h;
            this.Experience = experience;
        }

        private int Experience { get; set; }

        public int Health { get; set; }

        public int GiveExperience()
        {
            if (!this.IsDead())
            {
                throw new InvalidOperationException("Target is not dead.");
            }

            return this.Experience;
        }

        public bool IsDead()
        {
            return this.Health <= 0;
        }

        public void TakeAttack(int attackPoints)
        {
            if (this.IsDead())
            {
                throw new InvalidOperationException("Dummy is dead.");
            }

            this.Health -= attackPoints;
        }
    }
}