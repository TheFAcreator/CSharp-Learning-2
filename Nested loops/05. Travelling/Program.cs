while (true)
{
    string country = Console.ReadLine();
    if (country == "End") break;
    double budget = double.Parse(Console.ReadLine());
    while (true)
    {
        string test = Console.ReadLine();
        if (test == "End") break;
        double i = double.Parse(test);
        budget -= i;
        if (budget <= 0)
        {
            Console.WriteLine($"Going to {country}!");
            break;
        }
    }
}