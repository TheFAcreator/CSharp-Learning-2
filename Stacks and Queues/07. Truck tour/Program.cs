int n = int.Parse(Console.ReadLine());
Queue<KeyValuePair<int, KeyValuePair<int, int>>> queue = new();
for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    int petrol = int.Parse(input[0]);
    int distance = int.Parse(input[1]);
    queue.Enqueue(new KeyValuePair<int, KeyValuePair<int, int>>(i, new KeyValuePair<int, int>(petrol, distance)));
}
while (true)
{
    int start = queue.Peek().Key;
    int petrol = queue.Peek().Value.Key;
    int distance = queue.Peek().Value.Value;
    if (petrol - distance >= 0)
    {
        petrol -= distance;
        queue.Dequeue();
        while (queue.Count > 0)
        {
            KeyValuePair<int, KeyValuePair<int, int>> current = queue.Dequeue();
            petrol += current.Value.Key;
            distance = current.Value.Value;
            if (petrol - distance < 0)
            {
                break;
            }
            petrol -= distance;
        }
        if (queue.Count == 0)
        {
            Console.WriteLine(start);
            break;
        }
        else
        {
            queue.Enqueue(new KeyValuePair<int, KeyValuePair<int, int>>(start, new KeyValuePair<int, int>(petrol, distance)));
        }
    }
    else
    {
        queue.Enqueue(queue.Dequeue());
    }
}