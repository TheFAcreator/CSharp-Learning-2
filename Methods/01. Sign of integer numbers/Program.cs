static void Check(int num)
{
    if (num > 0) Console.WriteLine($"The number {num} is positive. ");
    else if (num == 0) Console.WriteLine($"The number {num} is zero. ");
    else Console.WriteLine($"The number {num} is negative. ");
}
int num = int.Parse(Console.ReadLine());
Check(num);