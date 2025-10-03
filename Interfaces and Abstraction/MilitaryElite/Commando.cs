using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public List<IMission> Missions { get; private set; }

        public Commando(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            Missions = new List<IMission>();
        }

        public override string ToString()
        {
            StringBuilder result = new(base.ToString());

            result.AppendLine();
            result.AppendLine("Missions:");
            foreach (var mission in Missions)
            {
                result.AppendLine($"  {mission.ToString()}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
