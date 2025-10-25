int n = int.Parse(Console.ReadLine());
static void PrintTriangle(int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 1; j <= 1 + i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
    for (int i = 1; i <= n; i++) Console.Write(i + " ");
    Console.WriteLine();
    for (int i = n - 1; i > 0; i--)
    {
        for (int j = 1; j < 1 + i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
}
PrintTriangle(n);