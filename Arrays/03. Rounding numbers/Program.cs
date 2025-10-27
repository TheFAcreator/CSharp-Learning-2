using System.Linq;
double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine("{0} => {1}", nums[i], (int)Math.Round(nums[i], MidpointRounding.AwayFromZero));
}