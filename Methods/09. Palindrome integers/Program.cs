while (true)
{
    string input = Console.ReadLine();
    if (input != "END")
    {
        uint num = uint.Parse(input);
        Console.WriteLine(PalindromeChecker(num));
    }
    else break;
}
static bool PalindromeChecker(uint num)
{
    string num1 = num.ToString();
    string num2 = "";
    for (uint i = num; i >= 1; i /= 10)
    {
        num2 += i % 10;
    }
    if (num1 == num2) return true;
    return false;
}