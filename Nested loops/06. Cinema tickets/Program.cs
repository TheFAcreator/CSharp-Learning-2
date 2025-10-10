int student = 0;
int kid = 0;
int standart = 0;
int used = 0;
int tickets = 0;
string name = Console.ReadLine();
while (name != "Finish")
{
    int seats = int.Parse(Console.ReadLine());
    while (seats > used)
    {
        string input1 = Console.ReadLine();
        if (input1 == "End")
        {
            break;
        }
        switch (input1)
        {
            case "student":
                student++;
                break;
            case "standard":
                standart++;
                break;
            case "kid":
                kid++;
                break;
        }
        used++;
        tickets++;
    }
    Console.WriteLine($"{name} - {(double)used / seats * 100:f2}% full.");
    used = 0;
    name = Console.ReadLine();
}
Console.WriteLine($"Total tickets: " + tickets);
Console.WriteLine($"{(double)student / tickets * 100:f2}% student tickets.");
Console.WriteLine($"{(double)standart / tickets * 100:f2}% standard tickets.");
Console.WriteLine($"{(double)kid / tickets * 100:f2}% kids tickets.");