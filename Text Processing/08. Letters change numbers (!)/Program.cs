string[] strs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
double sum = 0;
for (int i = 0; i < strs.Length; i++)
{
    double num = double.Parse(strs[i].Substring(1, strs[i].Length - 2));
    int pos1 = Char.ToUpper(strs[i][0]) - 'A' + 1;
    int pos2 = Char.ToUpper(strs[i][strs[i].Length - 1]) - 'A' + 1;
    if (Char.IsUpper(strs[i][0])) num /= pos1;
    else num *= pos1;
    if (Char.IsUpper(strs[i][strs[i].Length - 1])) num -= pos2;
    else num += pos2;
    sum += num;
}
Console.WriteLine($"{sum:f2}");