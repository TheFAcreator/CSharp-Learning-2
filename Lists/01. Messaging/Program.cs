string[] nums = Console.ReadLine().Split();
System.Collections.Generic.List<char> txt = Console.ReadLine().ToCharArray().ToList();
string result = "";
for (int i = 0; i < nums.Length; i++)
{
    int index = 0;
    for (int j = 0; j < nums[i].Length; j++) index += int.Parse(nums[i][j].ToString());
    if (index >= txt.Count) index = index % txt.Count;
    result += txt[index];
    txt.RemoveAt(index);
}
Console.WriteLine(result);