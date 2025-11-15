using LegendsOfValor_TheGuildTrials.Models.Contracts;
using LegendsOfValor_TheGuildTrials.Utilities.Messages;

namespace LegendsOfValor_TheGuildTrials.Models
{
    public abstract class Hero : IHero
    {
        private string name;
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ErrorMessages.InvalidHeroName);
                }
                name = value;
            }
        }

        private string runeMark;
        public string RuneMark
        {
            get => runeMark;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ErrorMessages.InvalidHeroRuneMark);
                }
                runeMark = value;
            }
        }

        public string GuildName { get; private set; }

        public int Power { get; protected set; }

        public int Mana { get; protected set; }

        public int Stamina { get; protected set; }

        protected Hero(string name, string runeMark, int power, int mana, int stamina)
        {
            Name = name;
            RuneMark = runeMark;
            Power = power;
            Mana = mana;
            Stamina = stamina;
        }

        public string Essence()
        {
            return $"Essence Revealed - Power [{Power}] Mana [{Mana}] Stamina [{Stamina}]";
        }

        public void JoinGuild(IGuild guild)
        {
            this.GuildName = guild.Name;
        }

        public override string ToString()
        {
            return $"Hero: [{Name}] of the Guild '{GuildName}' - RuneMark: {RuneMark}";
        }

        public abstract void Train();
    }
}
