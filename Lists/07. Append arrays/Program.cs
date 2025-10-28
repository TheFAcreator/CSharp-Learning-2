using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] elements = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
        List<string> ints = new();
        for (int i = elements.Length - 1; i >= 0; i--)
        {
            string[] numbersIn = elements[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
            ints.AddRange(numbersIn);
        }
        Console.WriteLine(string.Join(" ", ints));
    }
}