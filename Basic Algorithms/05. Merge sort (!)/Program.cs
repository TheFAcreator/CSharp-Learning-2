class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        MergeSort(array);
        Console.WriteLine(string.Join(" ", array));
    }

    static void MergeSort<T>(T[] array) where T : IComparable<T>
    {
        if (array.Length <= 1) return;

        T[] firstPart = array.Take(array.Length / 2).ToArray();
        T[] secondPart = array.Skip(array.Length / 2).ToArray();

        MergeSort(firstPart);
        MergeSort(secondPart);

        Merge(array, firstPart, secondPart);
    }
    static void Merge<T>(T[] array, T[] firstPart, T[] secondPart) where T : IComparable<T>
    {
        int firstIndex = 0, secondIndex = 0, arrayIndex = 0;

        while (firstIndex < firstPart.Length && secondIndex < secondPart.Length)
        {
            if (firstPart[firstIndex].CompareTo(secondPart[secondIndex]) <= 0)
            {
                array[arrayIndex++] = firstPart[firstIndex++];
            }
            else
            {
                array[arrayIndex++] = secondPart[secondIndex++];
            }
        }

        while (firstIndex < firstPart.Length)
        {
            array[arrayIndex++] = firstPart[firstIndex++];
        }

        while (secondIndex < secondPart.Length)
        {
            array[arrayIndex++] = secondPart[secondIndex++];
        }
    }
}