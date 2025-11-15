using FootballManager.Models.Contracts;
using FootballManager.Repositories.Contracts;

namespace FootballManager.Repositories
{
    public class TeamRepository : IRepository<ITeam>
    {
        private readonly List<ITeam> teams = new List<ITeam>();

        public IReadOnlyCollection<ITeam> Models => teams.AsReadOnly();

        public int Capacity { get; private set; } = 0;

        public void Add(ITeam model)
        {
            if (Capacity < 10)
            {
                teams.Add(model);
                Capacity++;
            }
        }

        public bool Exists(string name)
        {
            return teams.Any(t => t.Name == name);
        }

        public ITeam Get(string name)
        {
            return teams.FirstOrDefault(t => t.Name == name);
        }

        public bool Remove(string name)
        {
            var team = Get(name);
            if (team != null)
            {
                teams.Remove(team);
                Capacity--;
                return true;
            }
            return false;
        }
    }
}
