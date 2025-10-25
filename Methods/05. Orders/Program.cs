static void Price(string product, int quantity)
{
    switch (product)
    {
        case "coffee":
            Console.WriteLine($"{quantity * 1.5:f2}");
            break;
        case "water":
            Console.WriteLine($"{quantity * 1.00:f2}");
            break;
        case "coke":
            Console.WriteLine($"{quantity * 1.4:f2}");
            break;
        case "snacks":
            Console.WriteLine($"{quantity * 2.00:f2}");
            break;
    }
}
string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
Price(product, quantity);