using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string regex = @"(?:\s)([a-z\d]+(?:[\.\-_][a-z\d]+)*@[a-z]+(?:[.-][a-z]+)*\.[a-z]+)";
        string text = Console.ReadLine();
        MatchCollection matches = Regex.Matches(text, regex);
        foreach (Match match in matches)
            Console.WriteLine(match.Groups[1].Value);
    }
}