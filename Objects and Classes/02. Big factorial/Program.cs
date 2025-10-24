using System.Numerics;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        BigInteger n = 1;
        for (int i = num; i > 0; i--)
        {
            n *= i;
        }
        Console.WriteLine(n);
    }
}