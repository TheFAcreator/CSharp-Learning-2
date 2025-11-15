int production = int.Parse(Console.ReadLine());
short count = short.Parse(Console.ReadLine());
int competingResult = int.Parse(Console.ReadLine());
int cookies = 0;
for (int i = 0; i < 30; i++)
{
    if (i % 3 == 0)
        cookies += (int)Math.Floor(production * count * 0.75);
    else
        cookies += production * count;
}

Console.WriteLine($"You have produced {cookies} biscuits for the past month.");
if (cookies < competingResult) Console.WriteLine($"You produce {(competingResult - cookies) / (double)competingResult * 100:f2} percent less biscuits.");
else Console.WriteLine($"You produce {(cookies - competingResult) / (double)competingResult * 100:f2} percent more biscuits.");