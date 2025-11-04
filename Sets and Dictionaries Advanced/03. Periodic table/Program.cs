int n = int.Parse(Console.ReadLine());
HashSet<string> chemicalElements = new();

for (int i = 0; i < n; i++)
{
    string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    foreach (string element in elements)
    {
        chemicalElements.Add(element);
    }
}

chemicalElements = new(chemicalElements.OrderBy(x => x));
Console.WriteLine(string.Join(" ", chemicalElements));