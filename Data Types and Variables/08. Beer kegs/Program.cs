int n = int.Parse(Console.ReadLine());
decimal highestVolume = 0m;
string winner = "";
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    decimal radius = decimal.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());
    decimal volume = (decimal)Math.PI * (decimal)Math.Pow((double)radius, 2) * height;
    if (volume >= highestVolume)
    {
        highestVolume = volume;
        winner = name;
    }
}
Console.WriteLine(winner);