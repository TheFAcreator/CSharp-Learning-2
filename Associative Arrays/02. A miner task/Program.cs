using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string input = "";
        Dictionary<string, int> mined = new();
        while ((input = Console.ReadLine()) != "stop")
        {
            int quantity = int.Parse(Console.ReadLine());
            if (mined.ContainsKey(input)) mined[input] += quantity;
            else mined[input] = quantity;
        }
        foreach (var kvp in mined)
            Console.WriteLine(kvp.Key + " -> " + kvp.Value);
    }
}