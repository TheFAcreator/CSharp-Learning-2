using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        bool isChanged = false;
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                if (isChanged)
                    Console.WriteLine(string.Join(" ", nums));
                break;
            }
            string[] command = input.Split();
            switch (command[0])
            {
                case "Add":
                    nums.Add(int.Parse(command[1]));
                    isChanged = true;
                    break;
                case "Remove":
                    nums.Remove(int.Parse(command[1]));
                    isChanged = true;
                    break;
                case "RemoveAt":
                    nums.RemoveAt(int.Parse(command[1]));
                    isChanged = true;
                    break;
                case "Insert":
                    nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    isChanged = true;
                    break;
                case "Contains":
                    bool checker = nums.Contains(int.Parse(command[1]));
                    if (checker) Console.WriteLine("Yes");
                    else Console.WriteLine("No such number");
                    break;
                case "PrintEven":
                    List<int> evens = new();
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] % 2 == 0) evens.Add(nums[i]);
                    }
                    Console.WriteLine(string.Join(" ", evens));
                    break;
                case "PrintOdd":
                    List<int> odds = new();
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] % 2 == 1) odds.Add(nums[i]);
                    }
                    Console.WriteLine(string.Join(" ", odds));
                    break;
                case "GetSum":
                    int sum = 0;
                    for (int i = 0; i < nums.Count; i++) sum += nums[i];
                    Console.WriteLine(sum);
                    break;
                case "Filter":
                    List<int> filtered = new();
                    if (command[1] == "<")
                    {
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] < int.Parse(command[2])) filtered.Add(nums[i]);
                        }
                    }
                    else if (command[1] == ">")
                    {
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] > int.Parse(command[2])) filtered.Add(nums[i]);
                        }
                    }
                    else if (command[1] == "<=")
                    {
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] <= int.Parse(command[2])) filtered.Add(nums[i]);
                        }
                    }
                    else if (command[1] == ">=")
                    {
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] >= int.Parse(command[2])) filtered.Add(nums[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", filtered));
                    break;
            }
        }
    }
}