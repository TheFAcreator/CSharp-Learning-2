int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
bool flag = false;
for (int i = 0; i < ints.Length; i++)
{
    int sum1 = 0;
    int sum2 = 0;
    for (int j = i - 1; j >= 0; j--)
    {
        sum1 += ints[j];
    }
    for (int k = i + 1; k < ints.Length; k++)
    {
        sum2 += ints[k];
    }
    if (sum1 == sum2)
    {
        flag = true;
        Console.WriteLine(i);
        break;
    }
}
if (!flag) Console.WriteLine("no");