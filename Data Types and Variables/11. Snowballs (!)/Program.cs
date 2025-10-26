// Program may not work correctly in some cases of input (chance of proper output - 90/100)

using System.Numerics;
byte n = byte.Parse(Console.ReadLine());
BigInteger best = 0;
double bestS = 0;
double bestT = 0;
double bestQ = 0;
for (int i = 0; i < n; i++)
{
    double snow = double.Parse(Console.ReadLine());
    double time = double.Parse(Console.ReadLine());
    double quality = double.Parse(Console.ReadLine());
    BigInteger calculate = (BigInteger)Math.Pow(snow / time, quality);
    if (calculate >= best)
    {
        best = calculate;
        bestS = snow;
        bestT = time;
        bestQ = quality;
    }
}
Console.WriteLine($"{bestS} : {bestT} = {best} ({bestQ})");