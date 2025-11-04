Dictionary<string, Dictionary<string, double>> shops = new();
string input = "";

while ((input = Console.ReadLine()) != "Revision")
{
    string[] analyzer = input.Split(", ");
    string shop = analyzer[0];
    string product = analyzer[1];
    double price = double.Parse(analyzer[2]);
    if (!shops.ContainsKey(shop))
    {
        shops[shop] = new();
    }
    shops[shop].Add(product, price);
}

shops = shops.OrderBy(x => x.Key, StringComparer.OrdinalIgnoreCase).ToDictionary(x => x.Key, x => x.Value);

foreach (var kvp in shops)
{
    Console.WriteLine(kvp.Key + "->");

    foreach (var product in kvp.Value)
    {
        Console.WriteLine("Product: " + product.Key + ", Price: " + product.Value);
    }
}