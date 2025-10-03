using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public List<IRepair> RepairsByHours { get; private set; }

        public Engineer(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            RepairsByHours = new List<IRepair>();
        }

        public override string ToString()
        {
            StringBuilder result = new(base.ToString());

            result.AppendLine();
            result.AppendLine("Repairs:");
            foreach (var repair in RepairsByHours)
            {
                result.AppendLine($"  {repair.ToString()}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
