int n = int.Parse(Console.ReadLine());
int num = 0;
int num2 = 0;
int num3 = 1;
Console.Write(1 + " ");
for (int i = 0; i < n - 1; i++) Console.Write(TribonacciNumber(ref num, ref num2, ref num3) + " ");
static int TribonacciNumber(ref int num, ref int num2, ref int num3)
{
    int sumNum = num + num2 + num3;
    num = num2;
    num2 = num3;
    num3 = sumNum;
    return sumNum;
}