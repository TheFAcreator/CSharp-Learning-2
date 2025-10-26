int n = int.Parse(Console.ReadLine());
int capacity = int.Parse(Console.ReadLine());
int count = 0;
while (n > 0)
{
    n -= capacity;
    count++;
}
Console.WriteLine(count);