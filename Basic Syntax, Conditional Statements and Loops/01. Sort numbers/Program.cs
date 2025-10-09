double[] nums = new double[3];
nums[0] = double.Parse(Console.ReadLine());
nums[1] = double.Parse(Console.ReadLine());
nums[2] = double.Parse(Console.ReadLine());
Array.Sort(nums);
Array.Reverse(nums);
foreach (double j in nums)
{
    Console.WriteLine(j);
}