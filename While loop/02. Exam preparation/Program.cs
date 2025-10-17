int bads = int.Parse(Console.ReadLine());
int bads1 = 0;
int sum = 0;
int count = 0;
string copy = "";
while (true)
{
    string name = Console.ReadLine();
    if (name == "Enough")
    {
        Console.WriteLine($"Average score: {(double)sum / (count + bads1):f2}");
        Console.WriteLine($"Number of problems: {count + bads1}");
        Console.WriteLine($"Last problem: {copy}");
        break;
    }
    else
    {
        copy = name;
        int grade = int.Parse(Console.ReadLine());
        if (grade <= 4) bads1++;
        else count++;
        sum += grade;
        if (bads1 == bads)
        {
            Console.WriteLine($"You need a break, {bads} poor grades.");
            break;
        }
    }
}