using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<char> symbs = Console.ReadLine().ToCharArray().ToList();
        List<int> nums = new();
        List<int> take = new();
        List<int> skip = new();
        for (int i = 0; i < symbs.Count; i++)
        {
            if (char.IsDigit(symbs[i]))
            {
                int num = int.Parse(symbs[i].ToString());
                nums.Add(num);
                symbs.RemoveAt(i);
                i--;
            }
        }
        for (int i = 0; i < nums.Count; i++)
        {
            if (i % 2 == 0) take.Add(nums[i]);
            else skip.Add(nums[i]);
        }
        string result = "";
        int toSkip = 0;
        for (int i = 0; i < take.Count; i++)
        {
            result += new string(symbs.Skip(toSkip).Take(take[i]).ToArray());
            toSkip += skip[i] + take[i];
        }
        Console.WriteLine(result);
    }
}