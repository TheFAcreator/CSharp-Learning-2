int letters = int.Parse(Console.ReadLine());
int counter = letters + 96;
for (char letter = 'a'; letter <= counter; letter++)
{
    for (char letter2 = 'a'; letter2 <= counter; letter2++)
    {
        for (char letter3 = 'a'; letter3 <= counter; letter3++)
        {
            Console.WriteLine($"{letter}{letter2}{letter3}");
        }
    }
}