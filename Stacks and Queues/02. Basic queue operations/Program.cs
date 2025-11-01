string[] analyzer = Console.ReadLine().Split();
int add = int.Parse(analyzer[0]);
int pop = int.Parse(analyzer[1]);
int check = int.Parse(analyzer[2]);
string[] numbers = Console.ReadLine().Split();
Queue<int> queue = new();
for (int i = 0; i < add; i++)
{
    queue.Enqueue(int.Parse(numbers[i]));
}
for (int i = 0; i < pop; i++)
{
    if (queue.Count > 0)
    {
        queue.Dequeue();
    }
}
if(queue.Count == 0)
{
    Console.WriteLine(0);
}
else
{
    if (queue.Contains(check))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine(queue.Min());
    }
}