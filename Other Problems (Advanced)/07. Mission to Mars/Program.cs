Stack<int> solarEnergy = new(Console.ReadLine().Split(", ").Select(int.Parse));
Queue<int> dailyDistances = new(Console.ReadLine().Split(", ").Select(int.Parse));

Dictionary<string, int> minerals = new()
{
    { "Iron", 80 },
    { "Titanium", 90 },
    { "Aluminium", 100 },
    { "Chlorine", 60 },
    { "Sulfur", 70 }
};

int collectedMinerals = 0;

while(solarEnergy.Count > 0 && dailyDistances.Count > 0)
{
    int total = solarEnergy.Pop() + dailyDistances.Dequeue();

    if(total >= minerals.ElementAt(collectedMinerals).Value)
    {
        collectedMinerals++;
    }

    if(collectedMinerals == minerals.Count)
    {
        Console.WriteLine("Mission complete! All minerals have been collected.");
        break;
    }
}

if(collectedMinerals < minerals.Count)
{
    Console.WriteLine("Mission not completed! Awaiting further instructions from Earth.");
}
if(collectedMinerals > 0)
{
    Console.WriteLine("Collected resources:");

    for (int i = 0; i < collectedMinerals; i++)
    {
        Console.WriteLine(minerals.ElementAt(i).Key);
    }
}