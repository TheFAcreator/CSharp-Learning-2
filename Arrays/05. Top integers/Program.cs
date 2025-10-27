int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < ints.Length; i++)
{
    int count = 0;
    for (int j = 1 + i; j < ints.Length; j++)
    {
        if (ints[i] > ints[j]) count++;
    }
    if (count == ints.Length - 1 - i) Console.Write(ints[i] + " ");
}