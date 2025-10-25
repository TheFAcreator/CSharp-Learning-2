string input = Console.ReadLine();
static string GetMiddleCharacter(string str)
{
    if (str.Length % 2 == 0) return str[str.Length / 2 - 1].ToString() + str[str.Length / 2].ToString();
    else return str[str.Length / 2].ToString();
}
Console.WriteLine(GetMiddleCharacter(input));