namespace LegendsOfValor_TheGuildTrials.Models
{
    public class Spellblade : Hero
    {
        // Allowed Guilds: "WarriorGuild", "SorcererGuild"
        public Spellblade(string name, string runeMark) : base(name, runeMark, 50, 60, 60)
        {
        }

        public override void Train()
        {
            this.Power += 15;
            this.Mana += 10;
            this.Stamina += 10;
        }
    }
}
