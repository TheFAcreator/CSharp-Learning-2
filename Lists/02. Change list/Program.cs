using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                Console.WriteLine(string.Join(" ", ints));
                break;
            }
            string[] analyzer = input.Split();
            if (analyzer[0] == "Delete")
            {
                for (int i = 0; i < ints.Count; i++)
                {
                    if (ints[i] == int.Parse(analyzer[1]))
                    {
                        ints.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (analyzer[0] == "Insert")
            {
                ints.Insert(int.Parse(analyzer[2]), int.Parse(analyzer[1]));
            }
        }
    }
}