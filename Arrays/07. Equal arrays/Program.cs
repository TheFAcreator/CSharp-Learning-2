int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] nums2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
bool ide = false;
int sum = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] != nums2[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        ide = true;
        break;
    }
    sum += nums[i];
}
if (!ide) Console.WriteLine($"Arrays are identical. Sum: {sum}");