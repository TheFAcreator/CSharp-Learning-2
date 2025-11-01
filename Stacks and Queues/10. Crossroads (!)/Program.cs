int greenDuration = int.Parse(Console.ReadLine());
int freeWindowDuration = int.Parse(Console.ReadLine());
int carsPassed = 0;
Queue<string> queue = new();
bool flag = false;
while (true)
{
    string input = Console.ReadLine();
    if (input == "END")
    {
        Console.WriteLine("Everyone is safe.");
        Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
        break;
    }
    else if (input == "green")
    {
        int green = greenDuration;
        int total = greenDuration + freeWindowDuration;
        while (queue.Count > 0)
        {
            int car = queue.Peek().Length;
            if (green - car >= 0)
            {
                green -= car;
                total -= car;
                carsPassed++;
                queue.Dequeue();
                if (green == 0) break;
            }
            else if (total - car >= 0)
            {
                carsPassed++;
                queue.Dequeue();
                break;
            }
            else
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{queue.Peek()} was hit at {queue.Peek()[car + (total - car)]}."); // (+) * (-) = (-)
                flag = true;
                break;
            }
        }
    }
    else
    {
        queue.Enqueue(input);
    }
    if (flag) break;
}