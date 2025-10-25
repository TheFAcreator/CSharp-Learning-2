double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double x3 = double.Parse(Console.ReadLine());
double y3 = double.Parse(Console.ReadLine());
double x4 = double.Parse(Console.ReadLine());
double y4 = double.Parse(Console.ReadLine());
if (LineLength(x1, y1, x2, y2) < LineLength(x3, y3, x4, y4))
{
    if (Value(x3, y3) > Value(x4, y4)) Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
    else Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
}
else
{
    if (Value(x1, y1) > Value(x2, y2)) Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
    else Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
}
static double LineLength(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
static double Value(double x1, double y1)
{
    return Math.Abs(x1) + Math.Abs(y1);
}