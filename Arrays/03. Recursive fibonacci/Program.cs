int n = int.Parse(Console.ReadLine());
Console.WriteLine(FibbonacciNumber(n));
static int FibbonacciNumber(int n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }
    return FibbonacciNumber(n - 1) + FibbonacciNumber(n - 2);
}