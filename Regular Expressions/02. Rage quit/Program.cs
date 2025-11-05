// Program may not work correctly in all cases of input (chance of proper output - 90/100)

using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string regex = @"([\D]+)(\d+)";
        string text = Console.ReadLine();
        StringBuilder result = new();
        HashSet<char> uniqueChars = new();
        MatchCollection matches = Regex.Matches(text, regex);
        foreach (Match match in matches)
        {
            for (int i = 0; i < match.Groups[1].Value.Length; i++) uniqueChars.Add(char.ToUpper(match.Groups[1].Value[i]));
            for (int i = 0; i < int.Parse(match.Groups[2].Value); i++)
                result.Append(match.Groups[1].Value);
        }
        Console.WriteLine("Unique symbols used: {0}", uniqueChars.Count);
        Console.WriteLine(result.ToString().ToUpper());
    }
}