int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

Console.WriteLine(nums.Length);
Console.WriteLine(nums.Sum());