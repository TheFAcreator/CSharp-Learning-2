Stack<int> foodPortions = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Queue<int> stamina = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Dictionary<string, int> peaks = new()
{
    { "Vihren", 80 },
    { "Kutelo", 90 },
    { "Banski Suhodol", 100 },
    { "Polezhan", 60 },
    { "Kamenitza", 70 }
};
int conqueredPeaks = 0;

while(foodPortions.Count > 0 && stamina.Count > 0 && conqueredPeaks < peaks.Count)
{
    int food = foodPortions.Pop();
    int staminaValue = stamina.Dequeue();
    int totalStamina = food + staminaValue;

    string currentPeak = peaks.ElementAt(conqueredPeaks).Key;
    int peakStamina = peaks[currentPeak];

    if (totalStamina >= peakStamina)
    {
        conqueredPeaks++;
    }
}

if(conqueredPeaks == peaks.Count)
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}
else
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}

if(conqueredPeaks > 0)
{
    Console.WriteLine("Conquered peaks:");
    foreach (var peak in peaks.Take(conqueredPeaks))
    {
        Console.WriteLine($"{peak.Key}");
    }
}