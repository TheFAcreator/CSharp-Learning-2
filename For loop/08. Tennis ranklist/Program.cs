int n = int.Parse(Console.ReadLine());
int points = int.Parse(Console.ReadLine());
int copy = points;
int wins = 0;
for (int i = 0; i < n; i++)
{
    string stage = Console.ReadLine();
    switch (stage)
    {
        case "W":
            points += 2000;
            wins += 1;
            break;
        case "F":
            points += 1200;
            break;
        case "SF":
            points += 720;
            break;
    }
}
Console.WriteLine($"Final points: {points}");
int avg = Convert.ToInt32(Math.Floor((double)(points - copy) / (double)n));
Console.WriteLine($"Average points: {avg}");
Console.WriteLine($"{(double)wins / (double)n * 100:f2}%");