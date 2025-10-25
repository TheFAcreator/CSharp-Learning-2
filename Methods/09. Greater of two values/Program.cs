class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        if (type == "int")
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            GetMax(num, num2);
        }
        else if (type == "char")
        {
            char symb = char.Parse(Console.ReadLine());
            char symb2 = char.Parse(Console.ReadLine());
            GetMax(symb, symb2);
        }
        else
        {
            string str = Console.ReadLine();
            string str2 = Console.ReadLine();
            GetMax(str, str2);
        }
    }
    static void GetMax(int num1, int num2)
    {
        if (num1.CompareTo(num2) > 0) Console.WriteLine(num1);
        else Console.WriteLine(num2);
    }
    static void GetMax(char symb1, char symb2)
    {
        if (symb1.CompareTo(symb2) > 0) Console.WriteLine(symb1);
        else Console.WriteLine(symb2);
    }
    static void GetMax(string txt1, string txt2)
    {
        if (txt1.CompareTo(txt2) > 0) Console.WriteLine(txt1);
        else Console.WriteLine(txt2);
    }
}