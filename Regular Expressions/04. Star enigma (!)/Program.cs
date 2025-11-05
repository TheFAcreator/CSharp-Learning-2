using System.Text.RegularExpressions;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string regex = @"(?:[^@!\-:>
]+)?\@([A-Z][a-z]+)(?:[^@!\-:>]+)?\:(\d+)(?:[^@!\-:>]+)?\!(A|D)\!(?:[^@!\-:>]+)?\-\>(\d+)(?:[^@!\-:>
]+)?";
        int n = int.Parse(Console.ReadLine());
        List<string> attackedPlanets = new();
        List<string> destroyedPlanets = new();
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            string text = Console.ReadLine();
            for (int j = 0; j < text.Length; j++)
                if (char.ToLower(text[j]) == 's' || char.ToLower(text[j]) == 't' || char.ToLower(text[j]) == 'a' || char.ToLower(text[j]) == 'r')
                    count++;
            char[] array = text.ToCharArray();
            for (int j = 0; j < array.Length; j++)
                array[j] = (char)(array[j] - count);
            text = new string(array);
            Regex regex1 = new Regex(regex);
            Match match = regex1.Match(text);
            if (match.Success)
            {
                if (char.Parse(match.Groups[3].Value) == 'A')
                    attackedPlanets.Add(match.Groups[1].Value);
                else destroyedPlanets.Add(match.Groups[1].Value);
            }
        }
        attackedPlanets.Sort();
        destroyedPlanets.Sort();
        Console.WriteLine("Attacked planets: " + attackedPlanets.Count);
        foreach (string planet in attackedPlanets)
            Console.WriteLine("-> " + planet);
        Console.WriteLine("Destroyed planets: " + destroyedPlanets.Count);
        foreach (string planet in destroyedPlanets)
            Console.WriteLine("-> " + planet);
    }
}