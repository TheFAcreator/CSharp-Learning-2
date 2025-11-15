using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        string txt = Console.ReadLine();
        string pattern = @"([=/])([A-Z][A-Za-z]{2,})\1";
        var matches = Regex.Matches(txt, pattern);
        int points = 0;
        List<string> destinations = new List<string>();
        foreach (Match match in matches)
        {
            destinations.Add(match.Groups[2].Value);
            points += match.Groups[2].Value.Length;
        }
        Console.WriteLine("Destinations: " + string.Join(", ", destinations));
        Console.WriteLine("Travel Points: " + points);
    }
}