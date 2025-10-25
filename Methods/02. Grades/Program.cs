static void Check(double num)
{
    if (num < 3.00) Console.WriteLine("Fail");
    else if (num < 3.50) Console.WriteLine("Poor");
    else if (num < 4.50) Console.WriteLine("Good");
    else if (num < 5.50) Console.WriteLine("Very good");
    else Console.WriteLine("Excellent");
}
double num = double.Parse(Console.ReadLine());
Check(num);