using System.Text;

int n = int.Parse(Console.ReadLine());

Dictionary<string, int> names = new Dictionary<string, int>();
for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ");
    string name = input[0];
    int age = int.Parse(input[1]);
    names[name] = age;
}

string condition = Console.ReadLine();
int ageThreshold = int.Parse(Console.ReadLine());
string format = Console.ReadLine();

Func<int, bool> predicate;
if (condition == "younger")
{
    predicate = age => age < ageThreshold;
}
else // "older"
{
    predicate = age => age >= ageThreshold;
}

Console.WriteLine(Print(Where(names, predicate), format));


Dictionary<string, int> Where(Dictionary<string, int> source, Func<int, bool> predicate)
{
    Dictionary<string, int> result = new();
    foreach (var kvp in source)
    {
        if (predicate(kvp.Value))
        {
            result[kvp.Key] = kvp.Value;
        }
    }
    return result;
}

string Print(Dictionary<string, int> source, string format)
{
    StringBuilder res = new();

    foreach (var kvp in source)
    {
        if (format == "name")
        {
            res.AppendLine(kvp.Key);
        }
        else if (format == "age")
        {
            res.AppendLine(kvp.Value.ToString());
        }
        else // "name age"
        {
            res.AppendLine($"{kvp.Key} - {kvp.Value}");
        }
    }
    return res.ToString().TrimEnd();
}