int p = int.Parse(Console.ReadLine());
double b = 0;
if (p <= 100) b = 5;
else if (p <= 1000) b = p * 0.2;
else b = p * 0.1;
if (p % 2 == 0) b += 1;
if (p % 10 == 5) b += 2;
Console.WriteLine(b);
Console.WriteLine(p + b);