using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                Console.WriteLine(string.Join(" ", nums));
                break;
            }
            string[] command = input.Split();
            switch (command[0])
            {
                case "Add":
                    nums.Add(int.Parse(command[1]));
                    break;
                case "Remove":
                    nums.Remove(int.Parse(command[1]));
                    break;
                case "RemoveAt":
                    nums.RemoveAt(int.Parse(command[1]));
                    break;
                case "Insert":
                    nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    break;
            }
        }
    }
}