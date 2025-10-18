string txt1 = Console.ReadLine();
System.Text.StringBuilder txt = new(txt1);
for (int i = 0; i < txt.Length; i++)
{
    if (txt[i] == '>')
    {
        int power = txt[i + 1] - '0';
        while (power > 0)
        {
            if (i + 1 >= txt.Length) break;
            if (txt[i + 1] == '>')
            {
                power += txt[i + 2] - '0';
                i++;
            }
            else
            {
                txt = txt.Remove(i + 1, 1);
                power--;
            }
        }
    }
}
Console.WriteLine(txt);