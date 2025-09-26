class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Shuffle(array);
        QuickSort(array);

        Console.WriteLine(string.Join(" ", array));
    }

    static void QuickSort<T>(T[] array) where T : IComparable<T>
    {
        QuickSort(array, 0, array.Length - 1);
    }
    static void QuickSort<T>(T[] array, int low, int high) where T : IComparable<T>
    {
        if(low < high)
        {
            int pivotIndex = Partition(array, low, high);

            QuickSort(array, low, pivotIndex);
            QuickSort(array, pivotIndex + 1, high);
        }
    }
    static int Partition<T>(T[] array, int low, int high) where T : IComparable<T>
    {
        T pivot = array[low];
        int i = low - 1;
        int j = high + 1;

        while (true)
        {
            do
            {
                i++;
            } while (array[i].CompareTo(pivot) < 0);

            do
            {
                j--;
            } while (array[j].CompareTo(pivot) > 0);

            if (i >= j)
                return j;

            Swap(array, i, j);
        }
    }
    static void Swap<T>(T[] array, int i, int j)
    {
        (array[j], array[i]) = (array[i], array[j]);
    }
    static void Shuffle<T>(T[] array)
    {
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            int r = rand.Next(i, array.Length); 
            Swap(array, i, r);
        }
    }
}