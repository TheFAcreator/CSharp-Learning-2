using System.Text.RegularExpressions;
using System.Collections.Generic;
class Customer
{
    public string Name { get; set; }
    public string Purchase { get; set; }
    public double Paid { get; set; }
}
class Program
{
    static void Main()
    {
        string regex = @"%([A-Z][a-z]+)%[^|%$.]*<(\w+)>[^|%$.]*\|(\d+)\|[^|%$.]*?(\d+\.\d+|\d+)\$";
        string input = "";
        double earnings = 0;
        List<Customer> customers = new();
        while ((input = Console.ReadLine()) != "end of shift")
        {
            Match match = Regex.Match(input, regex);
            if (!match.Success) continue;
            double purchase = int.Parse(match.Groups[3].Value) * double.Parse(match.Groups[4].Value);
            earnings += purchase;
            customers.Add(new Customer() { Name = match.Groups[1].Value, Purchase = match.Groups[2].Value, Paid = purchase });
        }
        foreach (Customer customer in customers)
            Console.WriteLine($"{customer.Name}: {customer.Purchase} - {customer.Paid:f2}");
        Console.WriteLine($"Total income: {earnings:f2}");
    }
}