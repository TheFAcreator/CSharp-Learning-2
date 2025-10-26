int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int copy = n;
int count = 0;
while (copy >= m)
{
    copy -= m;
    if (copy * 2 == n) if (y != 0) copy /= y;
    count++;
}
Console.WriteLine(copy);
Console.WriteLine(count);