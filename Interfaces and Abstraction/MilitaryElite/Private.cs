using MilitaryElite.Interfaces;

namespace MilitaryElite
{
    public class Private : Soldier, IPrivate
    {
        public decimal Salary { get; protected set; }

        public Private(int id, string firstName, string lastName, decimal salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {Salary:f2}";
        }
    }
}
