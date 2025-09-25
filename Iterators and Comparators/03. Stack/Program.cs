using System.Collections;

public class Stack<T> : IEnumerable<T>
{
    private List<T> items = new();

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("No elements");
        }

        T item = items[^1];
        items.RemoveAt(items.Count - 1);
        return item;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = items.Count - 1; i >= 0; i--)
        {
            yield return items[i];
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
        Stack<int> stack = new();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] analyzer = input.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
            string command = analyzer[0];

            switch (command)
            {
                case "Push":
                    int[] numbers = analyzer[1].Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    foreach (var number in numbers)
                    {
                        stack.Push(number);
                    }
                    break;
                case "Pop":
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }
        }

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}