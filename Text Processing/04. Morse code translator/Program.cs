using System.Text;

public class Program
{
    static void Main()
    {
        string morseCode = Console.ReadLine();
        string[] words = morseCode.Split('|', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();
        Dictionary<string, char> morseToLetter = new Dictionary<string, char>
        {
        {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'},
        {"..-.", 'F'}, {"--.", 'G'}, {"....", 'H'}, {"..", 'I'}, {".---", 'J'},
        {"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'}, {"---", 'O'},
        {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'},
        {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'}, {"-.--", 'Y'},
        {"--..", 'Z'}
        };
        foreach (string word in words)
        {
            string[] letters = word.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string letter in letters)
            {
                result.Append(morseToLetter[letter]);
            }
            result.Append(' ');
        }
        Console.WriteLine(result.ToString().Trim());
    }
}