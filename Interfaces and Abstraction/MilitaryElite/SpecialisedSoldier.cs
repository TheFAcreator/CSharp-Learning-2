using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public string Corps { get; private set; }

        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public override string ToString()
        {
            StringBuilder result = new(base.ToString());

            result.AppendLine();
            result.AppendLine($"Corps: {Corps}");

            return result.ToString().TrimEnd();
        }
    }
}
