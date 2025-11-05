using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
        string text = Console.ReadLine();
        MatchCollection matches = Regex.Matches(text, regex);
        foreach (Match match in matches)
            Console.Write(match.Value + " ");
    }
}