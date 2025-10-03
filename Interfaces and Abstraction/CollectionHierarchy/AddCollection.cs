using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy
{
    public class AddCollection : IAddCollection
    {
        public List<string> Items { get; } = new List<string>();

        public int Add(string item)
        {
            Items.Add(item);

            return Items.Count - 1; // Return the index of the added item
        }
    }
}
