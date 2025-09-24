int n = int.Parse(Console.ReadLine());
int sum = 0;
int sum2 = 0;
for (int i = 0; i < n; i += 2)
{
    sum += int.Parse(Console.ReadLine());
    if (i + 1 < n) sum2 += int.Parse(Console.ReadLine());
}
if (sum == sum2)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + sum);
}
else
{
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + Math.Abs(sum - sum2));
}