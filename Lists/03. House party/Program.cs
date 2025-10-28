using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> list = new();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            if (input[2] == "not")
            {
                if (list.Contains(input[0])) list.Remove(input[0]);
                else Console.WriteLine($"{input[0]} is not in the list!");
            }
            else
            {
                if (list.Contains(input[0])) Console.WriteLine($"{input[0]} is already in the list!");
                else list.Add(input[0]);
            }
        }
        for (int i = 0; i < list.Count; i++) Console.WriteLine(list[i]);
    }
}