int[] racers = Console.ReadLine().Split().Select(int.Parse).ToArray();
double sum1 = 0;
bool zero = false;
for (int i = 0; i < racers.Length / 2; i++)
{
    if (racers[i] == 0 && !zero)
    {
        sum1 -= sum1 * 0.2;
        zero = true;
    }
    else sum1 += racers[i];
}
zero = false;
double sum2 = 0;
for (int i = racers.Length - 1; i > racers.Length / 2; i--)
{
    if (racers[i] == 0 && !zero)
    {
        sum2 -= sum2 * 0.2;
        zero = true;
    }
    else sum2 += racers[i];
}
if (sum1 > sum2) Console.WriteLine("The winner is right with total time: " + sum2);
else Console.WriteLine("The winner is left with total time: " + sum1);