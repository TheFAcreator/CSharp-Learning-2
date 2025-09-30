namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value;
            }
        }

        public int Rating
        {
            get
            {
                return players.Count == 0 ? 0 : (int)Math.Round(players.Average(p => p.SkillLevel));
            }
        }

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string player)
        {
            if (players.Any(n => n.Name == player))
            {
                Player player1 = players.First(n => n.Name == player);
                players.Remove(player1);
            }
            else
            {
                throw new InvalidOperationException($"Player {player} is not in {this.Name} team.");
            }
        }
    }
}
