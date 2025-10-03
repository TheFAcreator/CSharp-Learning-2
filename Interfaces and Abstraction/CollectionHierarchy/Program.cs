using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy;

public class StartUp
{
    static void Main(string[] args)
    {
        IAddCollection addCollection = new AddCollection();
        IAddRemoveCollection addRemoveCollection = new AddRemoveCollection();
        IMyList myList = new MyList();

        string[] itemsToAdd = Console.ReadLine().Split();

        foreach (var item in itemsToAdd)
        {
            Console.Write(addCollection.Add(item) + " ");
        }

        Console.WriteLine();
        foreach (var item in itemsToAdd)
        {
            Console.Write(addRemoveCollection.Add(item) + " ");
        }

        Console.WriteLine();
        foreach (var item in itemsToAdd)
        {
            Console.Write(myList.Add(item) + " ");
        }

        Console.WriteLine();
        int removeCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < removeCount; i++)
        {
            Console.Write(addRemoveCollection.Remove() + " ");
        }

        Console.WriteLine();
        for (int i = 0; i < removeCount; i++)
        {
            Console.Write(myList.Remove() + " ");
        }
    }
}