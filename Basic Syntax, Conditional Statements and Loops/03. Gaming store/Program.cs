double balance = double.Parse(Console.ReadLine());
double copy = balance;
string input = "";
while ((input = Console.ReadLine()) != "Game Time")
{
    switch (input)
    {
        case "OutFall 4":
            PurchaseRequest(39.99, input, ref balance);
            break;
        case "CS: OG":
            PurchaseRequest(15.99, input, ref balance);
            break;
        case "Zplinter Zell":
            PurchaseRequest(19.99, input, ref balance);
            break;
        case "Honored 2":
            PurchaseRequest(59.99, input, ref balance);
            break;
        case "RoverWatch":
            PurchaseRequest(29.99, input, ref balance);
            break;
        case "RoverWatch Origins Edition":
            PurchaseRequest(39.99, input, ref balance);
            break;
        default:
            Console.WriteLine("Not Found");
            break;
    }
    if (balance == 0)
    {
        Console.WriteLine("Out of money!");
        break;
    }
}
static void PurchaseRequest(double price, string input, ref double balance)
{
    if (balance - price < 0) Console.WriteLine("Too Expensive");
    else
    {
        Console.WriteLine("Bought " + input);
        balance -= price;
    }
}
if (balance != 0) Console.WriteLine($"Total spent: ${copy - balance:f2}. Remaining: ${balance:f2}");