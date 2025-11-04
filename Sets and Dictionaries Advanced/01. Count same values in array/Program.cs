double[] values = Console.ReadLine().Split().Select(double.Parse).ToArray();
Dictionary<double, int> counts = new();

for (int i = 0; i < values.Length; i++)
{
    if (counts.ContainsKey(values[i]))
    {
        counts[values[i]]++;
    }
    else
    {
        counts[values[i]] = 1;
    }
}

foreach(var pair in counts)
{
    Console.WriteLine($"{pair.Key} - {pair.Value} times");
}