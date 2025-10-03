namespace MilitaryElite.Interfaces
{
    public interface ILeutenantGeneral : IPrivate
    {
        public List<IPrivate> Privates { get; }
    }
}
