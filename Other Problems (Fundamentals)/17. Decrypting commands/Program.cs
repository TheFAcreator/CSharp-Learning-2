using System.Text;
class Program
{
    static void Main()
    {
        StringBuilder str = new(Console.ReadLine());
        string input = "";
        while ((input = Console.ReadLine()) != "Finish")
        {
            string[] analyzer = input.Split();
            switch (analyzer[0])
            {
                case "Replace":
                    str.Replace(analyzer[1], analyzer[2]);
                    Console.WriteLine(str);
                    break;
                case "Cut":
                    if (validIndices(int.Parse(analyzer[1]), int.Parse(analyzer[2]), str))
                    {
                        str.Remove(int.Parse(analyzer[1]), int.Parse(analyzer[2]) - int.Parse(analyzer[1]) + 1);
                        Console.WriteLine(str);
                    }
                    break;
                case "Make":
                    if (analyzer[1] == "Upper") str = new StringBuilder(str.ToString().ToUpper());
                    else str = new StringBuilder(str.ToString().ToLower());
                    Console.WriteLine(str);
                    break;
                case "Check":
                    if (str.ToString().Contains(analyzer[1])) Console.WriteLine($"Message contains {analyzer[1]}");
                    else Console.WriteLine($"Message doesn't contain {analyzer[1]}");
                    break;
                case "Sum":
                    if (validIndices(int.Parse(analyzer[1]), int.Parse(analyzer[2]), str))
                    {
                        int sum = 0;
                        for (int i = int.Parse(analyzer[1]); i <= int.Parse(analyzer[2]); i++)
                        {
                            sum += str[i];
                        }
                        Console.WriteLine(sum);
                    }
                    break;
            }
        }
    }
    static bool validIndices(int startIndex, int endIndex, StringBuilder str)
    {
        if (startIndex >= 0 && startIndex < str.Length && endIndex >= 0 && endIndex < str.Length)
        {
            return true;
        }
        Console.WriteLine("Invalid indices!");
        return false;
    }
}