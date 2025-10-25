static double Pow(double num, int pow)
{
    double newNum = 1;
    if (pow == 0) return newNum = 0;
    for (int i = 0; i < pow; i++) newNum *= num;
    return newNum;
}
double num1 = double.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(Pow(num1, num2));