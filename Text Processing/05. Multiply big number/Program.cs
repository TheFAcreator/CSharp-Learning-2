string number = Console.ReadLine();
int multiplier = int.Parse(Console.ReadLine());
int toCarry = 0;
string result = string.Empty;
if (multiplier == 0) Console.WriteLine(0);
else
{
    for (int i = number.Length - 1; i >= 0; i--)
    {
        int num = number[i] - '0';
        int product = (num * multiplier) + toCarry;
        toCarry = product / 10;
        result = (product % 10) + result;
    }
    while (toCarry > 0)
    {
        result = (toCarry % 10) + result;
        toCarry /= 10;
    }
    Console.WriteLine(result);
}