namespace CollectionHierarchy.Interfaces
{
    public interface IAddCollection
    {
        protected List<string> Items { get; }
        public int Add(string item);
    }
}
