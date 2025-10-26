int n = int.Parse(Console.ReadLine());
int capacity = 255;
for (int i = 0; i < n; i++)
{
    int addLiters = int.Parse(Console.ReadLine());
    if (capacity - addLiters >= 0) capacity -= addLiters;
    else Console.WriteLine("Insufficient capacity!");
}
Console.WriteLine(255 - capacity);