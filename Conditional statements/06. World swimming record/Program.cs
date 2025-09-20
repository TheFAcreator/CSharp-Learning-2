double record = double.Parse(Console.ReadLine());
double s = double.Parse(Console.ReadLine());
double v = double.Parse(Console.ReadLine());
double timeNeeded = s * v;
double b = s / 15;
b = Math.Floor(b);
timeNeeded += b * 12.5;
if (timeNeeded >= record)
{
    Console.WriteLine($"No, he failed! He was {timeNeeded - record:f2} seconds slower.");
}
else
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {timeNeeded:f2} seconds.");
}