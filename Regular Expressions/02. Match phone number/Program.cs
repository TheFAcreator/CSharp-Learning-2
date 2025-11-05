using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string regex = @"(?<=\s|^)\+359(\s|-)2\1[0-9]{3}\1[0-9]{4}\b";
        string text = Console.ReadLine();
        var phoneMatches = Regex.Matches(text, regex);
        string[] extractedValues = phoneMatches.Cast<Match>().Select(j => j.Value.Trim()).ToArray();
        Console.WriteLine(string.Join(", ", extractedValues));
    }
}