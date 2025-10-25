string password = Console.ReadLine();
Validator(password);
static void Validator(string pass)
{
    if (FirstRule(pass))
    {
        bool flag = Rule2(pass);
        int count = 0;
        for (int i = 0; i < pass.Length; i++)
        {
            if ((int)pass[i] is >= 48 and <= 57) count++;
        }
        if (count < 2) Console.WriteLine("Password must have at least 2 digits");
    }
    else
    {
        if (Rule2(pass))
        {
            int count = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if ((int)pass[i] is >= 48 and <= 57) count++;
            }
            if (count < 2) Console.WriteLine("Password must have at least 2 digits");
        }
        else
        {
            int count = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if ((int)pass[i] is >= 48 and <= 57) count++;
            }
            if (count < 2) Console.WriteLine("Password must have at least 2 digits");
            else Console.WriteLine("Password is valid");
        }
    }
}
static bool Rule2(string pass)
{
    for (int i = 0; i < pass.Length; i++)
    {
        if ((int)pass[i] is >= 65 and <= 90 || (int)pass[i] is >= 48 and <= 57 || (int)pass[i] is >= 97 and <= 122) continue;
        else
        {
            Console.WriteLine("Password must consist only of letters and digits");
            return true;
        }
    }
    return false;
}
static bool FirstRule(string pass)
{
    if (pass.Length is <= 10 and >= 6) return false;
    else
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
        return true;
    }
}