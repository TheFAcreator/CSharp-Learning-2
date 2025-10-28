using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
        int capacity = int.Parse(Console.ReadLine());
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                Console.WriteLine(string.Join(" ", wagons));
                break;
            }
            string[] analyzer = input.Split();
            if (analyzer[0] == "Add")
            {
                wagons.Add(int.Parse(analyzer[1]));
            }
            else
            {
                for (int i = 0; i < wagons.Count; i++)
                {
                    if (wagons[i] + int.Parse(analyzer[0]) <= capacity)
                    {
                        wagons[i] += int.Parse(analyzer[0]);
                        break;
                    }
                }
            }
        }
    }
}