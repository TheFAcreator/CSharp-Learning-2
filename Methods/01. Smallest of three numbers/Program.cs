int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
static int SmallestIntergerFinder(int num, int num2, int num3)
{
    if (num2 < num)
    {
        if (num3 < num2) return num3;
        else return num2;
    }
    else
    {
        if (num3 < num) return num3;
        else return num;
    }
}
Console.WriteLine(SmallestIntergerFinder(num1, num2, num3));