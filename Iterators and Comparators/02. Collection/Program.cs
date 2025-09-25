using System.Collections;

public class ListyIterator<T> : IEnumerable<T>
{
    private List<T> items;
    private int index;

    public ListyIterator(params T[] items)
    {
        this.items = new List<T>(items);
    }

    public bool Move()
    {
        if (HasNext())
        {
            index++;
            return true;
        }
        return false;
    }

    public bool HasNext()
    {
        return index < items.Count - 1;
    }

    public void Print()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        Console.WriteLine(items[index]);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in items)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
public class StartUp
{
    static void Main(string[] args)
    {
        string[] analyzer = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        ListyIterator<string> listyIterator = new(analyzer.Skip(1).ToArray());

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            switch (input)
            {
                case "Move":
                    Console.WriteLine(listyIterator.Move());
                    break;
                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext());
                    break;
                case "Print":
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (InvalidOperationException ex) { Console.WriteLine(ex.Message); }

                    break;
                case "PrintAll":
                    foreach (var item in listyIterator)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();

                    break;
            }
        }
    }
}