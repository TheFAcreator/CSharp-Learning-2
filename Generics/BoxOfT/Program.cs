namespace BoxOfT
{
    public class Box<T>
    {
        List<T> items = new List<T>();

        public int Count => items.Count;

        public void Add(T item)
        {
            items.Add(item);
        }
        public T Remove()
        {
            T item = items[Count - 1];
            items.Remove(item);
            return item;
        }
    }

    public class StartUp
    {
        static void Main(string[] args)
        {

        }
    }
}