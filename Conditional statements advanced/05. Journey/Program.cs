double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
double price = 0;
if (budget <= 100)
{
    Console.WriteLine("Somewhere in Bulgaria");
    switch (season)
    {
        case "summer":
            price = budget * 0.3;
            Console.WriteLine($"Camp - {price:f2}");
            break;
        case "winter":
            price = budget * 0.7;
            Console.WriteLine($"Hotel - {price:f2}");
            break;
    }
}
else if (budget <= 1000)
{
    Console.WriteLine("Somewhere in Balkans");
    switch (season)
    {
        case "summer":
            price = budget * 0.4;
            Console.WriteLine($"Camp - {price:f2}");
            break;
        case "winter":
            price = budget * 0.8;
            Console.WriteLine($"Hotel - {price:f2}");
            break;
    }
}
else
{
    Console.WriteLine("Somewhere in Europe");
    price = budget * 0.9;
    Console.WriteLine($"Hotel - {price:f2}");
}