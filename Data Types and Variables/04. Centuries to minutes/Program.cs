int n = int.Parse(Console.ReadLine());
int y = n * 100;
double d = y * 365.2422;
int h = (int)d * 24;
int m = h * 60;
Console.WriteLine($"{n} centuries = {y} years = {(int)d} days = {h} hours = {m} minutes");