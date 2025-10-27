int n = int.Parse(Console.ReadLine());
int[] nums = new int[n];
for (int i = 0; i < n; i++)
{
    nums[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    Console.Write(nums[nums.Length - i - 1] + " ");
}