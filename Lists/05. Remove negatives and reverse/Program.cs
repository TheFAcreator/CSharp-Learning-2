using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        for (int i = 0; i < nums.Count; i++) if (nums[i] < 0)
            {
                nums.RemoveAt(i);
                i--;
            }
        if (nums.Count == 0) Console.WriteLine("empty");
        else
        {
            nums.Reverse();
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
        }
    }
}