using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string input = "";
        Dictionary<string, double> prices = new();
        Dictionary<string, int> quantities = new();
        while ((input = Console.ReadLine()) != "buy")
        {
            string[] analyzer = input.Split();
            if (prices.ContainsKey(analyzer[0]))
            {
                quantities[analyzer[0]] += int.Parse(analyzer[2]);
                prices[analyzer[0]] = double.Parse(analyzer[1]);
            }
            else
            {
                prices[analyzer[0]] = double.Parse(analyzer[1]);
                quantities[analyzer[0]] = int.Parse(analyzer[2]);
            }
        }
        foreach (var kvp in prices)
            prices[kvp.Key] = kvp.Value * quantities[kvp.Key];
        foreach (var kvp in prices)
            Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
    }
}