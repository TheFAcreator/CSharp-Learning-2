int n = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> studentRecord = new();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string name = input[0];
    decimal grade = decimal.Parse(input[1]);

    if(!studentRecord.ContainsKey(name))
    {
        studentRecord[name] = new List<decimal>();
    }
    studentRecord[name].Add(grade);
}

foreach(var kvp in studentRecord)
{
    Console.WriteLine($"{kvp.Key} -> {string.Join(" ", kvp.Value.Select(j => $"{j:f2}"))} (avg: {kvp.Value.Average():f2})");
}