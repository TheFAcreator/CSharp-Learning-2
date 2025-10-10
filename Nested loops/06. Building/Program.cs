int floors = int.Parse(Console.ReadLine());
int rooms = int.Parse(Console.ReadLine());
for (int i = floors; i > 0; i--)
{
    string marker = "";
    if (floors == i) marker = "L";
    else if (i % 2 == 0) marker = "O";
    else marker = "A";
    for (int j = 0; j < rooms; j++)
    {
        Console.Write(marker + i + j);
        if (j != rooms - 1) Console.Write(" ");
    }
    Console.WriteLine();
}