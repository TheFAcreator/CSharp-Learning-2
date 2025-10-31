using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string input = "";
        Dictionary<string, List<string>> companies = new();
        while ((input = Console.ReadLine()) != "End")
        {
            string[] analyzer = input.Split(" -> ");
            if (!companies.ContainsKey(analyzer[0]))
            {
                companies[analyzer[0]] = new();
                companies[analyzer[0]].Add(analyzer[1]);
            }
            else
            {
                if (!companies[analyzer[0]].Contains(analyzer[1]))
                {
                    companies[analyzer[0]].Add(analyzer[1]);
                }
            }
        }
        foreach (var kvp in companies)
        {
            Console.WriteLine(kvp.Key);
            foreach (string member in kvp.Value)
                Console.WriteLine("-- " + member);
        }
    }
}