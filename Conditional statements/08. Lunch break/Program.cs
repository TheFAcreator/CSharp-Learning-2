string name = Console.ReadLine();
int ep = int.Parse(Console.ReadLine());
int time = int.Parse(Console.ReadLine());
double time2 = time;
double lunch = time2 / 8;
double rest = time2 / 4;
time2 -= lunch;
time2 -= rest;
if (time2 >= ep)
{
    Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(time2 - ep)} minutes free time.");
}
else Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(ep - time2)} more minutes.");