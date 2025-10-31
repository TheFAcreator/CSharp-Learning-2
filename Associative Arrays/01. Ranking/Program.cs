using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<string, string> contests = new();
        string input = "";
        while ((input = Console.ReadLine()) != "end of contests")
        {
            string[] analyzer = input.Split(":");
            contests[analyzer[0]] = analyzer[1];
        }
        Dictionary<string, Dictionary<string, int>> users = new();
        while ((input = Console.ReadLine()) != "end of submissions")
        {
            string[] analyzer = input.Split("=>");
            if (contests.ContainsKey(analyzer[0]) && analyzer[1] == contests[analyzer[0]])
            {
                if (!users.ContainsKey(analyzer[2]))
                    users[analyzer[2]] = new Dictionary<string, int>();
                var currentContest = users[analyzer[2]].FirstOrDefault(k => k.Key == analyzer[0]);
                if (currentContest.Equals(default(KeyValuePair<string, int>)) || currentContest.Value < int.Parse(analyzer[3]))
                    users[analyzer[2]][analyzer[0]] = int.Parse(analyzer[3]);
            }
        }
        var winner = users.OrderByDescending(g => g.Value.Values.Sum()).FirstOrDefault();
        Console.WriteLine($"Best candidate is {winner.Key} with total {winner.Value.Values.Sum()} points.");
        Console.WriteLine("Ranking:");
        users = users.OrderBy(h => h.Key).ToDictionary(k => k.Key, k => k.Value);
        foreach (var kvp in users)
        {
            Console.WriteLine(kvp.Key);
            foreach (var kvp2 in kvp.Value.OrderByDescending(w => w.Value).ToDictionary(l => l.Key, l => l.Value))
                Console.WriteLine("#  " + kvp2.Key + " -> " + kvp2.Value);
        }
    }
}