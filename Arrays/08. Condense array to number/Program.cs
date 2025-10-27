int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
if (nums.Length == 1) Console.WriteLine(nums[0]);
else
{
    int[] save = new int[nums.Length - 1];
    int sum = 0;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        save[i] = nums[i] + nums[i + 1];
    }
    for (int i = 0; i < save.Length - 2; i++)
    {
        for (int k = 0; k < save.Length - 1 - i; k++) save[k] = save[k] + save[k + 1];
    }
    sum = save[0] + save[1];
    Console.WriteLine(sum);
}