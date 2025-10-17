double price = double.Parse(Console.ReadLine());
double budget = double.Parse(Console.ReadLine());
int count = 0;
int days = 0;
while (true)
{
    string action = Console.ReadLine();
    double money = double.Parse(Console.ReadLine());
    days++;
    if (action == "save")
    {
        count = 0;
        budget += money;
        if (budget >= price)
        {
            Console.WriteLine($"You saved the money for {days} days.");
            break;
        }
    }
    else
    {
        count++;
        budget -= money;
        if (budget < 0) budget = 0;
        if (count == 5)
        {
            Console.WriteLine($"You can't save the money.\n{days}");
            break;
        }
    }
}