int num = int.Parse(Console.ReadLine());

Console.WriteLine(Factorial(num));

static int Factorial(int num)
{
    if(num == 1) return 1;

    return num * Factorial(num - 1);
}