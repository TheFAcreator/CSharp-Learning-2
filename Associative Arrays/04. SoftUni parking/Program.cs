using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, string> registered = new();
        for (int i = 0; i < n; i++)
        {
            string[] analyzer = Console.ReadLine().Split();
            if (analyzer[0] == "register")
            {
                if (registered.ContainsKey(analyzer[1]))
                    Console.WriteLine($"ERROR: already registered with plate number {registered[analyzer[1]]}");
                else
                {
                    registered[analyzer[1]] = analyzer[2];
                    Console.WriteLine($"{analyzer[1]} registered {analyzer[2]} successfully");
                }
            }
            else
            {
                if (!registered.ContainsKey(analyzer[1]))
                    Console.WriteLine($"ERROR: user {analyzer[1]} not found");
                else
                {
                    registered.Remove(analyzer[1]);
                    Console.WriteLine($"{analyzer[1]} unregistered successfully");
                }
            }
        }
        foreach (var kvp in registered)
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
    }
}