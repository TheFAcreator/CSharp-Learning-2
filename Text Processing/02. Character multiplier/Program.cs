string[] analyzer = Console.ReadLine().Split();
Console.WriteLine(CharacterSum(analyzer[0], analyzer[1]));
static int CharacterSum(string str1, string str2)
{
    int bigger = Math.Max(str1.Length, str2.Length);
    int sum = 0;
    for (int i = 0; i < bigger; i++)
    {
        if (i >= str1.Length) sum += str2[i];
        else if (i >= str2.Length) sum += str1[i];
        else sum += str1[i] * str2[i];
    }
    return sum;
}