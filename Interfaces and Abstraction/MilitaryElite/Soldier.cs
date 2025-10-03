using MilitaryElite.Interfaces;

namespace MilitaryElite
{
    public abstract class Soldier : ISoldier
    {
        public int Id { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id}";
        }
    }
}