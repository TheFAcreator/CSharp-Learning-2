int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());
int[] ints2 = new int[ints.Length];
for (int i = 0; i < ints.Length; i++)
{
    int index = i - n;
    while (true)
    {
        if (index < 0) index += ints.Length;
        else break;
    }
    ints2[index] = ints[i];
}
foreach (int i in ints2)
{
    Console.Write(i + " ");
}