int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
static int AddAndSubstract(int num1, int num2, int num3)
{
    return Add(num1, num2) - num3;
}
static int Add(int num1, int num2)
{
    return num1 + num2;
}
Console.WriteLine(AddAndSubstract(num1, num2, num3));