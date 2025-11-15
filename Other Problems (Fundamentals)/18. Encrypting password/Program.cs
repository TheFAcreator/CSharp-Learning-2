using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string regex = @"(.+)>(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1";
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            Match match = Regex.Match(input, regex);
            if (match.Success)
            {
                Console.WriteLine($"Password: {match.Groups[2].Value}{match.Groups[3].Value}{match.Groups[4].Value}{match.Groups[5].Value}");
            }
            else
            {
                Console.WriteLine("Try another password!");
            }
        }
    }
}