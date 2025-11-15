Stack<int> caffeineMilligrams = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Queue<int> energyDrinks = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int totalCaffeine = 0;

while (true)
{
    int caffeine = caffeineMilligrams.Pop() * energyDrinks.Peek();

    if(totalCaffeine + caffeine <= 300)
    {
        energyDrinks.Dequeue();

        totalCaffeine += caffeine;
    }
    else
    {
        energyDrinks.Enqueue(energyDrinks.Dequeue());

        if(totalCaffeine - 30 <= 0)
        {
            totalCaffeine = 0;
        }
        else
        {
            totalCaffeine -= 30;
        }
    }

    if(energyDrinks.Count == 0)
    {
        Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
        break;
    }
    else if(caffeineMilligrams.Count == 0)
    {
        Console.WriteLine("Drinks left: " + string.Join(", ", energyDrinks));
        break;
    }
}

Console.WriteLine($"Stamat is going to sleep with {totalCaffeine} mg caffeine.");