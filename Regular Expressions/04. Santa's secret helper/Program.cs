using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string regex = @"@([A-Za-z]+)[^@!>\-:]*!(G|N)!";
        int n = int.Parse(Console.ReadLine());
        string input = "";
        while ((input = Console.ReadLine()) != "end")
        {
            char[] decoded = input.ToCharArray();
            for (int i = 0; i < decoded.Length; i++)
            {
                int newCode = decoded[i] - n;
                decoded[i] = (char)newCode;
            }
            Match match = Regex.Match(new string(decoded), regex);
            if (match.Success)
            {
                if (match.Groups[2].Value == "G") Console.WriteLine(match.Groups[1].Value);
            }
        }
    }
}