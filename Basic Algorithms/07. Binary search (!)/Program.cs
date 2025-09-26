class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int element = int.Parse(Console.ReadLine());
        
        int index = IndexOfBinarySearch(array, element);
        Console.WriteLine(index);
    }
    static int IndexOfBinarySearch<T>(T[] array, T element) where T : IComparable<T>
    {
        int low = 0;
        int high = array.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int comparison = array[mid].CompareTo(element);
            if (comparison == 0)
            {
                return mid;
            }
            else if (comparison < 0)
            {
                low = mid + 1; // right half
            }
            else
            {
                high = mid - 1; // left half
            }
        }
        return -1;
    }
}