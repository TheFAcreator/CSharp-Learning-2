using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();
        Dictionary<char, int> streaks = new();
        for (int i = 0; i < input.Length; i++)
        {
            if (!streaks.ContainsKey(input[i]) && input[i] != ' ')
                streaks[input[i]] = 0;
            if (input[i] != ' ') streaks[input[i]]++;
        }
        foreach (var kvp in streaks)
            Console.WriteLine(kvp.Key + " -> " + kvp.Value);
    }
}