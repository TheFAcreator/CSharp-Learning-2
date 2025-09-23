int h = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int h1 = int.Parse(Console.ReadLine());
int m1 = int.Parse(Console.ReadLine());
int start = h * 60 + m;
int arrival = h1 * 60 + m1;
int difference = Math.Abs(start - arrival);
int differenceH = difference / 60;
int differenceM = difference % 60;
if (start < arrival)
{
    Console.WriteLine("Late");
    if (differenceH > 0)
    {
        Console.WriteLine($"{differenceH}:{differenceM:d2} hours after the start");
    }
    else Console.WriteLine($"{differenceM} minutes after the start");
}
else if (difference <= 30)
{
    Console.WriteLine("On time");
    if (differenceH > 0)
    {
        Console.WriteLine($"{differenceH}:{differenceM:d2} hours before the start");
    }
    else
    {
        Console.WriteLine($"{differenceM} minutes before the start");
    }
}
else if (difference > 30)
{
    Console.WriteLine("Early");
    if (differenceH > 0)
    {
        Console.WriteLine($"{differenceH}:{differenceM:d2} hours before the start");
    }
    else Console.WriteLine($"{differenceM} minutes before the start");
}