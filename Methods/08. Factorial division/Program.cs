int num = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
static double Factorial(int num1)
{
    double result = 1;
    for (int i = num1; i > 1; i--) result *= i;
    return result;
}
Console.WriteLine($"{Factorial(num) / Factorial(num2):f2}");