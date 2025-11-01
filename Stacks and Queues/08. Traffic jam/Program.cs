int passed = 0;
int pass = int.Parse(Console.ReadLine());
Queue<string> cars = new();
string input = "";
while ((input = Console.ReadLine()) != "end")
{
    if (input == "green")
    {
        for (int i = 0; i < pass; i++)
        {
            if (cars.Count > 0)
            {
                Console.WriteLine($"{cars.Dequeue()} passed!");
                passed++;
            }
        }
    }
    else
    {
        cars.Enqueue(input);
    }
}
Console.WriteLine($"{passed} cars passed the crossroads.");