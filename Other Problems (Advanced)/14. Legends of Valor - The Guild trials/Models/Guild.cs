using LegendsOfValor_TheGuildTrials.Models.Contracts;
using LegendsOfValor_TheGuildTrials.Utilities.Messages;

namespace LegendsOfValor_TheGuildTrials.Models
{
    public class Guild : IGuild
    {
        private string name;
        public string Name
        {
            get => name;
            private set
            {
                if (value != "WarriorGuild" && value != "SorcererGuild" && value != "ShadowGuild")
                {
                    throw new ArgumentException(ErrorMessages.InvalidGuildName);
                }
                name = value;
            }
        }

        private int wealth;
        public int Wealth
        {
            get => wealth;
            set
            {
                if (wealth + value < 0)
                {
                    wealth = 0;
                }
                else
                {
                    wealth = value;
                }
            }
        }

        private List<string> legion;
        public IReadOnlyCollection<string> Legion
        {
            get => legion;
        }

        public bool IsFallen { get; private set; }

        public Guild(string name)
        {
            Name = name;
            wealth = 5000;
            legion = new List<string>();
            IsFallen = false;
        }

        public void LoseWar()
        {
            wealth = 0;
            IsFallen = true;
        }

        public void RecruitHero(IHero hero)
        {
            if (!legion.Contains(hero.RuneMark))
            {
                legion.Add(hero.RuneMark);
            }
        }

        public void TrainLegion(ICollection<IHero> heroesToTrain)
        {
            foreach (var hero in heroesToTrain)
            {
                wealth -= 200;
                hero.Train();
            }
        }

        public void WinWar(int goldAmount)
        {
            wealth += goldAmount;
        }
    }
}
