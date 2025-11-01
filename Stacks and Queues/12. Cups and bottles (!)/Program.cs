Queue<int> cups = new(Console.ReadLine().Split().Select(int.Parse));
Stack<int> bottles = new(Console.ReadLine().Split().Select(int.Parse));
int wastedWater = 0;
int currentCup = 0;
while (cups.Count > 0 && bottles.Count > 0)
{
    currentCup = cups.Peek() - bottles.Peek();
    if(currentCup > 0)
    {
        bottles.Pop();
        while (currentCup > 0 && bottles.Count > 0)
        {
            if(currentCup - bottles.Peek() > 0) currentCup -= bottles.Pop();
            else
            {
                wastedWater += bottles.Pop() - currentCup;
                cups.Dequeue();
                break;
            }
        }
    }
    else
    {
        wastedWater += bottles.Pop() - cups.Dequeue();
    }
}
if (bottles.Count == 0 && cups.Count > 0)
{
    Console.WriteLine("Cups: " + string.Join(" ", cups));
}
else
{
    Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
}
Console.WriteLine($"Wasted litters of water: {wastedWater}");