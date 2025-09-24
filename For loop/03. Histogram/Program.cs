int n = int.Parse(Console.ReadLine());
int c = 0;
int c2 = 0;
int c3 = 0;
int c4 = 0;
int c5 = 0;
for (int i = 0; i < n; i++)
{
    int j = int.Parse(Console.ReadLine());
    if (j < 200) c += 1;
    else if (j < 400) c2 += 1;
    else if (j < 600) c3 += 1;
    else if (j < 800) c4 += 1;
    else c5 += 1;
}
double p = (double)c / n * 100;
double p2 = (double)c2 / n * 100;
double p3 = (double)c3 / n * 100;
double p4 = (double)c4 / n * 100;
double p5 = (double)c5 / n * 100;
Console.WriteLine($"{p:f2}%");
Console.WriteLine($"{p2:f2}%");
Console.WriteLine($"{p3:f2}%");
Console.WriteLine($"{p4:f2}%");
Console.WriteLine($"{p5:f2}%");