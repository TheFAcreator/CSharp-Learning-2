using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
        if (nums.Count == 1) Console.WriteLine(nums[0]);
        else if (nums.Count == 2)
        {
            if (nums[0] == nums[1]) Console.WriteLine(nums[0] + nums[1]);
            else Console.WriteLine($"{nums[0]} {nums[1]}");
        }
        else
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] += nums[i + 1];
                    nums.Remove(nums[i + 1]);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}