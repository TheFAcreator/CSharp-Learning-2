int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int heigth = int.Parse(Console.ReadLine());
int space = width * length * heigth;
while (true)
{
    string input = Console.ReadLine();
    if (input != "Done")
    {
        int occupy = int.Parse(input);
        if (space - occupy <= 0)
        {
            Console.WriteLine($"No more free space! You need {occupy - space} Cubic meters more.");
            break;
        }
        space -= occupy;
    }
    else
    {
        Console.WriteLine($"{space} Cubic meters left.");
        break;
    }
}