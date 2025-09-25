public class Comparator : IComparer<int>
{
    public int Compare(int x, int y)
    {
        if (x % 2 == 0 && y % 2 != 0)
        {
            return -1; // x is even, y is odd
        }

        if (x % 2 != 0 && y % 2 == 0)
        {
            return 1; // x is odd, y is even
        }

        return x.CompareTo(y); // both are even or both are odd, compare normally
    }
}

public class StartUp
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Array.Sort(numbers, new Comparator());


        Console.WriteLine(string.Join(" ", numbers));
    }
}