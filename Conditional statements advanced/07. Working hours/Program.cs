int h = int.Parse(Console.ReadLine());
string day = Console.ReadLine();
if (h >= 10 && h <= 18)
{
    switch (day)
    {
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
        case "Saturday":
            Console.WriteLine("open");
            break;
        case "Sunday":
            Console.WriteLine("closed");
            break;
    }
}
else
{
    Console.WriteLine("closed");
}