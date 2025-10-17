int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int pieces = width * length;
while (true)
{
    string input = Console.ReadLine();
    if (input != "STOP")
    {
        int take = int.Parse(input);
        if (pieces - take <= 0)
        {
            Console.WriteLine($"No more cake left! You need {take - pieces} pieces more.");
            break;
        }
        pieces -= take;
    }
    else
    {
        Console.WriteLine($"{pieces} pieces are left.");
        break;
    }
}