string[] banned = Console.ReadLine().Split(", ");
string text = Console.ReadLine();
while (true)
{
    int index = -1;
    string copy = text;
    for (int i = 0; i < banned.Length; i++)
    {
        index = text.IndexOf(banned[i]);
        if (index != -1)
        {
            string replacement = new string('*', banned[i].Length);
            text = text.Substring(0, index) + replacement + text.Substring(index + banned[i].Length);
        }
    }
    if (copy == text) break;
}
Console.WriteLine(text);