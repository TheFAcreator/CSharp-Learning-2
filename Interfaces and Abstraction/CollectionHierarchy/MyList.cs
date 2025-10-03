using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy
{
    public class MyList : AddRemoveCollection, IMyList
    {
        public new string Remove()
        {
            string result = Items[0];
            Items.RemoveAt(0);

            return result;
        }

        public int Used => Items.Count;
    }
}
