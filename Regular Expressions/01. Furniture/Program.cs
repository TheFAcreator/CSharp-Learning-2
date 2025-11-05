using System.Text.RegularExpressions;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string regex = @"\>\>(?<name>[A-Za-z]+)\<\<(?<price>\d+\.?\d*)\!(?<quantity>\d+)";
        string input = "";
        double spent = 0;
        List<string> names = new();
        while ((input = Console.ReadLine()) != "Purchase")
        {
            Regex regex1 = new Regex(regex);
            if (regex1.IsMatch(input))
            {
                Match match = regex1.Match(input);
                names.Add(match.Groups["name"].Value);
                spent += double.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["quantity"].Value);
            }
        }
        Console.WriteLine("Bought furniture:");
        foreach (string name in names) Console.WriteLine(name);
        Console.WriteLine($"Total money spend: {spent:f2}");
    }
}