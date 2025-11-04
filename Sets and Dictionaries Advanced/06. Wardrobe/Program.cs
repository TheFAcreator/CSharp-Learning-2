int n = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, int>> wardrobe = new();

for(int i = 0; i < n; i++)
{
    string[] analyzer = Console.ReadLine().Split(" -> ");
    string color = analyzer[0];
    string[] clothes = analyzer[1].Split(",");
    if (!wardrobe.ContainsKey(color))
    {
        wardrobe[color] = new();
    }
    foreach (string cloth in clothes)
    {
        if (!wardrobe[color].ContainsKey(cloth))
        {
            wardrobe[color][cloth] = 0;
        }
        wardrobe[color][cloth]++;
    }
}

string[] search = Console.ReadLine().Split();
string searchColor = search[0];
string searchCloth = search[1];

foreach(var kvp in wardrobe)
{
    Console.WriteLine(kvp.Key + " clothes:");
    foreach(var kvp2 in wardrobe[kvp.Key])
    {
        if (kvp.Key == searchColor && kvp2.Key == searchCloth)
        {
            Console.WriteLine($"* {kvp2.Key} - {kvp2.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {kvp2.Key} - {kvp2.Value}");
        }
    }
}