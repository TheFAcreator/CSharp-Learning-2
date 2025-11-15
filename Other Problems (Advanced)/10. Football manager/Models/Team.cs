using FootballManager.Models.Contracts;
using FootballManager.Utilities.Messages;

namespace FootballManager.Models
{
    public class Team : ITeam
    {
        private string name;
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.TeamNameNull);
                }

                name = value;
            }
        }

        public Team(string name)
        {
            this.Name = name;
        }

        public int ChampionshipPoints { get; private set; } = 0;

        public IManager TeamManager { get; private set; } = null;

        public int PresentCondition
        {
            get
            {
                if (TeamManager == null)
                {
                    return 0;
                }
                if (ChampionshipPoints == 0)
                {
                    return (int)Math.Floor(TeamManager.Ranking);
                }

                return (int)Math.Floor(TeamManager.Ranking * ChampionshipPoints);
            }
        }

        public void GainPoints(int points)
        {
            this.ChampionshipPoints += points;
        }

        public void ResetPoints()
        {
            this.ChampionshipPoints = 0;
        }

        public void SignWith(IManager manager)
        {
            this.TeamManager = manager;
        }

        public override string ToString()
        {
            return $"Team: {this.Name} Points: {this.ChampionshipPoints}";
        }
    }
}
