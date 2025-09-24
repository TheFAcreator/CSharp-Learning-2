int n = int.Parse(Console.ReadLine());
int max = int.MinValue;
int sum = 0;
for (int i = 0; i < n; i++)
{
    int j = int.Parse(Console.ReadLine());
    if (j > max) max = j;
    sum += j;
}
if (max == sum - max)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + max);
}
else
{
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + Math.Abs(max - sum + max));
}