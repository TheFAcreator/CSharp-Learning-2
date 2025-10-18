string txt = Console.ReadLine();
string str = string.Empty;
for (int i = 0; i < txt.Length; i++)
{
    char ch = txt[i];
    Console.Write(ch);
    int g = i;
    for (int j = 1; ; j++)
    {
        if (g + j >= txt.Length) break;
        if (txt[g + j] == ch) i++;
        else break;
    }
}