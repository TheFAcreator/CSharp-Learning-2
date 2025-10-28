using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();
        bool bigger = false;
        if (nums2.Count > nums1.Count) bigger = true;
        List<int> nums = new();
        for (int i = 0; i < Math.Min(nums1.Count, nums2.Count); i++)
        {
            nums.Add(nums1[i]);
            nums.Add(nums2[nums2.Count - i - 1]);
        }
        int range1 = 0, range2 = 0;
        if (!bigger)
        {
            range1 = Math.Min(nums1[nums1.Count - 1], nums1[nums1.Count - 2]);
            range2 = Math.Max(nums1[nums1.Count - 1], nums1[nums1.Count - 2]);
        }
        else
        {
            range1 = Math.Min(nums2[0], nums2[1]);
            range2 = Math.Max(nums2[0], nums2[1]);
        }
        List<int> validNums = nums.Where(n => n > range1 && n < range2).ToList();
        validNums = validNums.OrderBy(j => j).ToList();
        Console.WriteLine(string.Join(" ", validNums));
    }
}