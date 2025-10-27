int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] count = new int[ints.Length];
int[] nums = new int[ints.Length];
nums[0] = ints[0];
int j = 0;
int k = 0;
for (int i = 1; i < ints.Length; i++)
{
    if (nums[k] == ints[i]) count[j]++;
    else
    {
        k++;
        nums[k] = ints[i];
        j++;
    }
}
int max = count[0];
k = 0;
for (int i = 1; i < count.Length; i++)
{
    if (count[i] > max) { max = count[i]; k = i; }
}
for (int i = 0; i < max + 1; i++) Console.Write(nums[k] + " ");