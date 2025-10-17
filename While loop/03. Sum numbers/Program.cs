int num = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int sum = n;
while (sum < num)
{
    n = int.Parse(Console.ReadLine());
    sum += n;
}
Console.WriteLine(sum);