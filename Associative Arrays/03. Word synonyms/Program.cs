using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<string>> wordsSynonyms = new();
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            if (!wordsSynonyms.ContainsKey(input)) wordsSynonyms[input] = new();
            wordsSynonyms[input].Add(Console.ReadLine());
        }
        foreach (KeyValuePair<string, List<string>> kvp in wordsSynonyms)
            Console.WriteLine("{0} - {1}", kvp.Key, string.Join(", ", kvp.Value));
    }
}