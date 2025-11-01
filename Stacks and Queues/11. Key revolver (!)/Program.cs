int bulletPrice = int.Parse(Console.ReadLine());
int sizeGunBarrel = int.Parse(Console.ReadLine());
Stack<int> bullets = new(Console.ReadLine().Split().Select(int.Parse));
Queue<int> locks = new(Console.ReadLine().Split().Select(int.Parse));
int intelligenceValue = int.Parse(Console.ReadLine());

int bulletsUsed = 0;

while (bullets.Count > 0 && locks.Count > 0)
{
    for (int i = 0; i < sizeGunBarrel; i++)
    {
        if (bullets.Count == 0 || locks.Count == 0) break;

        if (bullets.Pop() <= locks.Peek())
        {
            locks.Dequeue();
            Console.WriteLine("Bang!");
        }
        else
        {
            Console.WriteLine("Ping!");
        }

        bulletsUsed++;
    }

    if(bullets.Count > 0 && bulletsUsed % sizeGunBarrel == 0) Console.WriteLine("Reloading!");
}

if (bullets.Count == 0 && locks.Count > 0)
{
    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
}
else
{
    Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligenceValue - (bulletsUsed * bulletPrice)}");
}