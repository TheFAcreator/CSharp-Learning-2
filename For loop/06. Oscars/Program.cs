string name = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
double max = 1;
for (int i = 0; i < n; i++)
{
    string name1 = Console.ReadLine();
    double points1 = double.Parse(Console.ReadLine());
    double points2 = ((name1.Length * points1) / 2) + points;
    if (points2 > max) max = points2;
    if (points2 >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points2:f1}!");
        break;
    }
    else
    {
        if (i == n - 1)
        {
            Console.WriteLine($"Sorry, {name} you need {1250.5 - max:f1} more!");
            break;
        }
        else points = points2;
    }
}