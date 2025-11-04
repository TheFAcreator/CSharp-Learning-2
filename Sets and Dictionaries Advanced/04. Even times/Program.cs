int n = int.Parse(Console.ReadLine());
HashSet<int> nums = new();
int[] ints = new int[n];

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    nums.Add(num);
    ints[i] = num;
}

foreach(int num in nums)
{
    if(ints.Count(x => x == num) % 2 == 0)
    {
        Console.Write(num);
        break;
    }
}