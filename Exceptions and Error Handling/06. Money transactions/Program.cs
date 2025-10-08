Dictionary<string, decimal> accounts = new();

string[] accountsGiven = Console.ReadLine()!.Split(",");
foreach (string account in accountsGiven)
{
    string[] accountInfo = account.Split("-");
    string name = accountInfo[0];
    decimal balance = decimal.Parse(accountInfo[1]);

    accounts[name] = balance;
}

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] analyzer = input.Split();
    string command = analyzer[0];
    string name = analyzer[1];

    try
    {
        if (!accounts.ContainsKey(name))
        {
            throw new Exception("Invalid account!");
        }

        decimal? amount = null;
        try
        {
            amount = decimal.Parse(analyzer[2]); // get amount from input
        }
        catch (FormatException)
        {
            throw new Exception("Invalid command!");
        }

        if (command == "Deposit")
        {
            accounts[name] += amount.Value;

            Console.WriteLine($"Account {name} has new balance: {accounts[name]:f2}");
        }
        else if (command == "Withdraw")
        {
            if (amount > accounts[name])
            {
                throw new Exception("Insufficient balance!");
            }

            accounts[name] -= amount.Value;

            Console.WriteLine($"Account {name} has new balance: {accounts[name]:f2}");
        }
        else
        {
            throw new Exception("Invalid command!");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Enter another command");
    }
}