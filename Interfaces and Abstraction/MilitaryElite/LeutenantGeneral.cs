using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            Privates = new List<IPrivate>();
        }

        public List<IPrivate> Privates { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new(base.ToString());

            result.AppendLine();
            result.AppendLine("Privates:");
            foreach (var privateSoldier in Privates)
            {
                result.AppendLine($"  {privateSoldier.ToString()}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
