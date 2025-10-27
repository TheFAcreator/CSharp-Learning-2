int n = int.Parse(Console.ReadLine());
int[] ints = new int[n];
int sum = 0;
for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    sum += input;
    ints[i] = input;
}
foreach (int i in ints)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine(sum);