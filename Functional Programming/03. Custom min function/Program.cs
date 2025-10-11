Func<int[], int> getMin = (arr) =>
{
    int min = arr[0];
    foreach (var num in arr)
    {
        if (num < min)
        {
            min = num;
        }
    }
    return min;
};

Console.WriteLine(getMin(Console.ReadLine().Split().Select(int.Parse).ToArray()));