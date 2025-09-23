string product = Console.ReadLine();
string city = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
if (city == "Sofia")
{
    switch (product)
    {
        case "coffee":
            Console.WriteLine(0.5 * quantity);
            break;
        case "water":
            Console.WriteLine(0.8 * quantity);
            break;
        case "beer":
            Console.WriteLine(1.2 * quantity);
            break;
        case "sweets":
            Console.WriteLine(1.45 * quantity);
            break;
        case "peanuts":
            Console.WriteLine(1.6 * quantity);
            break;
    }
}
else if (city == "Plovdiv")
{
    switch (product)
    {
        case "coffee":
            Console.WriteLine(0.4 * quantity);
            break;
        case "water":
            Console.WriteLine(0.7 * quantity);
            break;
        case "beer":
            Console.WriteLine(1.15 * quantity);
            break;
        case "sweets":
            Console.WriteLine(1.30 * quantity);
            break;
        case "peanuts":
            Console.WriteLine(1.5 * quantity);
            break;
    }
}
else
{
    switch (product)
    {
        case "coffee":
            Console.WriteLine(0.45 * quantity);
            break;
        case "water":
            Console.WriteLine(0.7 * quantity);
            break;
        case "beer":
            Console.WriteLine(1.1 * quantity);
            break;
        case "sweets":
            Console.WriteLine(1.35 * quantity);
            break;
        case "peanuts":
            Console.WriteLine(1.55 * quantity);
            break;
    }
}