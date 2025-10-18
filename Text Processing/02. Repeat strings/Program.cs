string[] strings = Console.ReadLine().Split();
string result = "";
for (int i = 0; i < strings.Length; i++)
{
    result += string.Concat(Enumerable.Repeat(strings[i], strings[i].Length));
}
Console.WriteLine(result);