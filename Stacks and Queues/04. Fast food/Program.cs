int food = int.Parse(Console.ReadLine());
Queue<int> orders = new(Console.ReadLine().Split().Select(int.Parse));
int maxOrder = orders.Max();
Console.WriteLine(maxOrder);
while (orders.Count > 0)
{
    if(food >= orders.Peek())
    {
        food -= orders.Dequeue();
    }
    else
    {
        break;
    }
}
Console.WriteLine(orders.Count == 0 ? "Orders complete" : $"Orders left: {string.Join(" ", orders)}");