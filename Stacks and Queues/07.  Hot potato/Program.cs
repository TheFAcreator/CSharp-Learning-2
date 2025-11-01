Queue<string> kids = new(Console.ReadLine().Split());
int toss = int.Parse(Console.ReadLine());
while(kids.Count > 1)
{
    for (int i = 0; i < toss - 1; i++)
    {
        kids.Enqueue(kids.Dequeue());
    }
    Console.WriteLine($"Removed {kids.Dequeue()}");
}
Console.WriteLine($"Last is {kids.Dequeue()}");