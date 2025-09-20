int hour = int.Parse(Console.ReadLine());
int sec = int.Parse(Console.ReadLine());
if (sec + 15 >= 60)
{
    int rem = 60 - sec;
    sec = 0 + 15 - rem;
    if (hour < 23)
        hour++;
    else
        hour = 0;
}
else
{
    sec += 15;
}
if (sec < 10)
    Console.WriteLine($"{hour}:0{sec}");
else
    Console.WriteLine($"{hour}:{sec}");