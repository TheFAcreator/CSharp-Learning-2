using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split();
        Dictionary<string, int> streak = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (streak.ContainsKey(nums[i].ToLower())) streak[nums[i].ToLower()]++;
            else streak[nums[i].ToLower()] = 1;
        }
        foreach (var t in streak)
            if (t.Value % 2 == 1) Console.Write(t.Key + " ");
    }
}