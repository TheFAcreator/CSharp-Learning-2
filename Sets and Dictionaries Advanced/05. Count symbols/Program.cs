string str = Console.ReadLine();
SortedDictionary<char, int> symbols = new();

foreach (char symbol in str)
{
    if (!symbols.ContainsKey(symbol))
    {
        symbols.Add(symbol, 0);
    }
    symbols[symbol]++;
}

foreach (var kvp in symbols)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
}