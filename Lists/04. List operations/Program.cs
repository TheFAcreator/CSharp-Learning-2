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
            if (input == "End")
            {
                Console.WriteLine(string.Join(" ", ints));
                break;
            }
            string[] analyzer = input.Split();
            switch (analyzer[0])
            {
                case "Add":
                    ints.Add(int.Parse(analyzer[1]));
                    break;
                case "Insert":
                    if (int.Parse(analyzer[2]) >= ints.Count || int.Parse(analyzer[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        break;
                    }
                    ints.Insert(int.Parse(analyzer[2]), int.Parse(analyzer[1]));
                    break;
                case "Remove":
                    if (int.Parse(analyzer[1]) >= ints.Count || int.Parse(analyzer[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        break;
                    }
                    ints.RemoveAt(int.Parse(analyzer[1]));
                    break;
                case "Shift":
                    int count = int.Parse(analyzer[2]) % ints.Count;
                    if (analyzer[1] == "left")
                    {
                        List<int> shiftPart = ints.GetRange(0, count);
                        ints.RemoveRange(0, count);
                        ints.InsertRange(ints.Count, shiftPart);
                    }
                    else if (analyzer[1] == "right")
                    {
                        List<int> shiftPart = ints.GetRange(ints.Count - count, count);
                        ints.RemoveRange(ints.Count - count, count);
                        ints.InsertRange(0, shiftPart);
                    }
                    break;
            }
        }
    }
}