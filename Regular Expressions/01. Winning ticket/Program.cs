// Program may not work correctly in all cases of input (chance of proper output - 20/100)

using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string regex = @"(@|\$|#|\^)\1{5, 9}";
        string[] tickets = Console.ReadLine().Split(",").Select(k => k.Trim()).ToArray();
        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i].Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }
            string half1 = tickets[i].Substring(0, 10);
            string half2 = tickets[i].Substring(10, 10);
            Match match1 = Regex.Match(half1, regex);
            Match match2 = Regex.Match(half2, regex);
            if (match1.Success && match2.Success && match1.Groups[0].Value[0] == match2.Groups[0].Value[0])
            {
                if (Regex.Match(half1, regex).Groups[0].Length == 10 && Regex.Match(half2, regex).Groups[0].Length == 10)
                    Console.WriteLine($"ticket \"{tickets[i]}\" - {match1.Length}{match1.Groups[0].Value[0]} Jackpot!");
                else Console.WriteLine($"ticket \"{tickets[i]}\" - {match1.Length}{match1.Groups[0].Value[0]}");
            }
        }
    }
}