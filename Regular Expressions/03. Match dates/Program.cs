using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string regex = @"\b(?<day>[0-9]{2})(?<separator>\.|-|\/)(?<month>[A-Z][a-z]{2})\2(?<year>[0-9]{4})\b";
        string text = Console.ReadLine();
        var dates = Regex.Matches(text, regex);
        foreach (Match match in dates)
        {
            string day = match.Groups["day"].Value;
            string month = match.Groups["month"].Value;
            string year = match.Groups["year"].Value;
            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
}