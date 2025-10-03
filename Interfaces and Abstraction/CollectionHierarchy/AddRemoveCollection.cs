using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        public List<string> Items { get; } = new List<string>();

        public int Add(string item)
        {
            Items.Insert(0, item); // Add to the start of the list

            return 0;
        }

        public string Remove()
        {
            string result = Items[Items.Count - 1];
            Items.RemoveAt(Items.Count - 1);

            return result;
        }
    }
}
