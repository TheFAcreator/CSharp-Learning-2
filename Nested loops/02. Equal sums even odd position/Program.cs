int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());
int sum1 = 0;
int sum2 = 0;
for (int i = min; i <= max; i++)
{
    int j = i;
    sum1 += j % 10;
    j /= 10;
    sum2 += j % 10;
    j /= 10;
    sum1 += j % 10;
    j /= 10;
    sum2 += j % 10;
    j /= 10;
    sum1 += j % 10;
    j /= 10;
    sum2 += j % 10;
    if (sum1 == sum2) Console.Write(i + " ");
    sum1 = 0;
    sum2 = 0;
}