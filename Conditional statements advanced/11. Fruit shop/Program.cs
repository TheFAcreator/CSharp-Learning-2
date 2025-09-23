string fruit = Console.ReadLine();
string day = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
double price = 0;
switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        switch (fruit)
        {
            case "banana":
                price = 2.5 * quantity;
                break;
            case "apple":
                price = 1.2 * quantity;
                break;
            case "orange":
                price = 0.85 * quantity;
                break;
            case "grapefruit":
                price = 1.45 * quantity;
                break;
            case "kiwi":
                price = 2.7 * quantity;
                break;
            case "pineapple":
                price = 5.5 * quantity;
                break;
            case "grapes":
                price = 3.85 * quantity;
                break;
            default:
                Console.WriteLine("error");
                break;
        }
        break;
    case "Saturday":
    case "Sunday":
        switch (fruit)
        {
            case "banana":
                price = 2.7 * quantity;
                break;
            case "apple":
                price = 1.25 * quantity;
                break;
            case "orange":
                price = 0.90 * quantity;
                break;
            case "grapefruit":
                price = 1.6 * quantity;
                break;
            case "kiwi":
                price = 3 * quantity;
                break;
            case "pineapple":
                price = 5.6 * quantity;
                break;
            case "grapes":
                price = 4.2 * quantity;
                break;
            default:
                Console.WriteLine("error");
                break;
        }
        break;
    default:
        Console.WriteLine("error");
        break;
}
if (price != 0)
{
    price = Math.Round(price, 2);
    Console.WriteLine($"{price:f2}");
}