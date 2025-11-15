int energy = int.Parse(Console.ReadLine());
int wins = 0;
while (energy >= 0)
{
    string input = Console.ReadLine();
    if (input == "End of battle")
    {
        Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
        break;
    }
    int distance = int.Parse(input);
    if (energy - distance >= 0)
    {
        wins++;
        if (wins % 3 == 0) energy += wins;
        energy -= distance;
    }
    else
    {
        Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
        break;
    }
}