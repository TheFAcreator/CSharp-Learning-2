int n = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, List<string>>> continents = new();

for(int i = 0; i < n; i++)
{
    string[] analyzer = Console.ReadLine().Split();
    string continent = analyzer[0];
    string country = analyzer[1];
    string city = analyzer[2];
    if (!continents.ContainsKey(continent))
    {
        continents[continent] = new();
    }
    if (!continents[continent].ContainsKey(country))
    {
        continents[continent][country] = new();
    }
    continents[continent][country].Add(city);
}

foreach(var kvp in continents)
{
    Console.WriteLine(kvp.Key + ":");
    foreach (var kvp2 in kvp.Value)
    {
        Console.WriteLine($"  {kvp2.Key} -> {string.Join(", ", kvp2.Value)}");
    }
}