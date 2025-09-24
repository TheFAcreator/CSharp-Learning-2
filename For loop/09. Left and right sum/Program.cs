int n = int.Parse(Console.ReadLine());
int sum = 0;
int sum2 = 0;
for (int i = 0; i < n; i++)
{
    sum += int.Parse(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    sum2 += int.Parse(Console.ReadLine());
}
if (sum == sum2) Console.WriteLine("Yes, sum = " + sum);
else Console.WriteLine("No, diff = " + Math.Abs(sum - sum2));