int num = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine(CheckerWithNoMultiplying(num, num2, num3));
static string CheckerWithNoMultiplying(int num, int num2, int num3)
{
    if (num < 0 || num2 < 0 || num3 < 0)
    {
        int count = 0;
        if (num < 0) count++;
        if (num2 < 0) count++;
        if (num3 < 0) count++;
        if (count == 2) return "positive";
        else return "negative";
    }
    if (num == 0 || num2 == 0 || num3 == 0) return "zero";
    return "positive";
}