using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string txt = Console.ReadLine();
        MatchCollection matches = Regex.Matches(txt, @"(@|#)([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1");
        Dictionary<string, string> pairs = new Dictionary<string, string>();
        foreach (Match match in matches)
        {
            string word1 = match.Groups[2].Value;
            string word2 = match.Groups[3].Value;
            if (new string(word1.Reverse().ToArray()) == word2) pairs.Add(word1, word2);
        }
        if (matches.Count == 0) Console.WriteLine("No word pairs found!");
        else Console.WriteLine($"{matches.Count} word pairs found!");
        if (pairs.Count == 0) Console.WriteLine("No mirror words!");
        else
        {
            Console.WriteLine("The mirror words are:");
            Console.WriteLine(string.Join(", ", pairs.Select(x => $"{x.Key} <=> {x.Value}")));
        }
    }
}