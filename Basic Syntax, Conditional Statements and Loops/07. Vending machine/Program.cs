double balance = 0;
bool flag = true;
while (flag)
{
    string input = Console.ReadLine();
    if (input != "Start")
    {
        double coin = double.Parse(input);
        switch (coin)
        {
            case 0.1:
            case 0.2:
            case 0.5:
            case 1:
            case 2:
                balance += coin;
                break;
            default:
                Console.WriteLine("Cannot accept " + coin);
                break;
        }
    }
    else
    {
        while (true)
        {
            string input2 = Console.ReadLine();
            if (input2 != "End")
            {
                double num = 0;
                switch (input2)
                {
                    case "Nuts":
                        if (balance >= 2) num = 2;
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Water":
                        if (balance >= 0.7) num = 0.7;
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Crisps":
                        if (balance >= 1.5) num = 1.5;
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Soda":
                        if (balance >= 0.8) num = 0.8;
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Coke":
                        if (balance >= 1) num = 1;
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (num != 0)
                {
                    balance -= num;
                    Console.WriteLine("Purchased " + input2.ToLower());
                }
            }
            else
            {
                Console.WriteLine($"Change: {balance:f2}");
                flag = false;
                break;
            }
        }
    }
}