namespace FakeAxeAndDummy
{
    public class Hero : IHero
    {
        public Hero(string name, int experience, IWeapon weapon)
        {
            this.Name = name;
            this.Experience = experience;
            this.Weapon = weapon;
        }

        public string Name { get; set; }

        public int Experience { get; set; }

        public IWeapon Weapon { get; set; }

        public void Attack(ITarget target)
        {
            this.Weapon.Attack(target);

            if (target.IsDead())
            {
                this.Experience += target.GiveExperience();
            }
        }
    }
}