using MilitaryElite.Interfaces;

namespace MilitaryElite
{
    public class Spy : Soldier, ISpy
    {
        public int CodeNumber { get; private set; }

        public Spy(int id, string firstName, string lastName, int codeNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}Code Number: {CodeNumber}";
        }
    }
}
