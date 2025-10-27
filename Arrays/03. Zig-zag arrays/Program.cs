int n = int.Parse(Console.ReadLine());
int[] array1 = new int[n];
int[] array2 = new int[n];
for (int i = 0; i < n; i++)
{
    int[] twoInts = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if (i % 2 == 0)
    {
        array1[i] = twoInts[0];
        array2[i] = twoInts[1];
    }
    else
    {
        array1[i] = twoInts[1];
        array2[i] = twoInts[0];
    }
}
foreach (int i in array1)
{
    Console.Write(i + " ");
}
Console.WriteLine();
foreach (int i in array2)
{
    Console.Write(i + " ");
}