// Program may not work correctly in all cases of input (chance of proper output - 70/100)

using System.Text.RegularExpressions;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string regex = @"([#$%&*])([A-Z]+)\1";
        string text = Console.ReadLine();
        string[] analyzer = text.Split("|");
        Match match = Regex.Match(analyzer[0], regex);
        char[] capitals = match.Groups[2].Value.ToCharArray();
        string regex2 = @"(\d{2}):(\d{2})";
        var mathes2 = Regex.Matches(analyzer[1], regex2);
        string regex3 = @"[A-Z][\S]+";
        var mathes3 = Regex.Matches(analyzer[2], regex3);
        foreach (Match match1 in mathes3)
        {
            if (!capitals.Contains(match1.Groups[0].Value[0])) continue;
            char capital = capitals[Array.IndexOf(capitals, match1.Groups[0].Value[0])];
            if (mathes2.Where(j => (char)(int.Parse(j.Groups[1].Value)) == capital && int.Parse(j.Groups[2].Value) == match1.Groups[0].Value.Length - 1).FirstOrDefault() != null)
                Console.WriteLine(match1.Groups[0].Value);
        }
    }
}