namespace LegendsOfValor_TheGuildTrials.Models
{
    public class Sorcerer : Hero
    {
        // Allowed Guilds: "SorcererGuild", "ShadowGuild"
        public Sorcerer(string name, string runeMark) : base(name, runeMark, 40, 120, 0)
        {
        }

        public override void Train()
        {
            this.Power += 20;
            this.Mana += 25;
        }
    }
}