using System.Collections.Generic;
class Program
{
    static void Main()
    {
        double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
        SortedDictionary<double, int> streak = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (streak.ContainsKey(nums[i])) streak[nums[i]]++;
            else streak[nums[i]] = 1;
        }
        foreach (var value in streak) Console.WriteLine($"{value.Key} -> {value.Value}");
    }
}