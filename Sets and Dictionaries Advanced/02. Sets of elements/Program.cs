int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] set1 = new int[lengths[0]];
HashSet<int> set2 = new HashSet<int>();

for(int i = 0; i < set1.Length; i++)
{
    int value = int.Parse(Console.ReadLine());
    if (!set1.Contains(value))
    {
        set1[i] = value;
    }
}
for (int i = 0; i < lengths[1]; i++)
{
    int value = int.Parse(Console.ReadLine());
    set2.Add(value);
}

var intersection = set1.Intersect(set2);
Console.WriteLine(string.Join(" ", intersection));