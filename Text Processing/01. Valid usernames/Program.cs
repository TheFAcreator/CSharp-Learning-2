string[] usernames = Console.ReadLine().Split(", ");
string valid = "";
for (int i = 0; i < usernames.Length; i++)
{
    if (usernames[i].Length is >= 3 and <= 16)
    {
        bool flag = false;
        for (int j = 0; j < usernames[i].Length; j++)
        {
            if (!(char.IsLetter(usernames[i][j]) || char.IsDigit(usernames[i][j]) || usernames[i][j] == '-' || usernames[i][j] == '_'))
            {
                flag = true;
                break;
            }
        }
        if (!flag) valid += usernames[i] + " ";
    }
}
string[] valid2 = valid.Split();
Console.WriteLine(string.Join(Environment.NewLine, valid2));