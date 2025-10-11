Action<int[], string> action = (nums, command) =>
{
    switch (command)
    {
        case "add":
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i]++;
            }
            break;
        case "multiply":
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= 2;
            }
            break;
        case "subtract":
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i]--;
            }
            break;
        case "print":
            Console.WriteLine(string.Join(" ", nums));
            break;
    }
};

int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
string input;

while ((input = Console.ReadLine()) != "end")
{
    action(nums, input);
}