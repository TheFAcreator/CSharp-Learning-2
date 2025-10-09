int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
if (minutes + 30 > 59)
{
    minutes -= 30;
    hour++;
}
else minutes += 30;
if (hour > 23) hour = 0;
Console.WriteLine($"{hour}:{minutes:D2}");