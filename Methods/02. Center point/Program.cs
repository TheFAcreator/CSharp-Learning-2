double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
if (Value(x1, y1) > Value(x2, y2)) Console.WriteLine($"({x2}, {y2})");
else Console.WriteLine($"({x1}, {y1})");
static double Value(double x1, double y1)
{
    return Math.Abs(x1) + Math.Abs(y1);
}