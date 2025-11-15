class MyClass
{
    static void Main(string[] args)
    {
        List<string> loot = Console.ReadLine().Split("|").ToList();
        string input;
        while ((input = Console.ReadLine()) != "Yohoho!")
        {
            string[] analyzer = input.Split();
            switch (analyzer[0])
            {
                case "Loot":
                    for (int i = 1; i < analyzer.Length; i++)
                    {
                        if (!loot.Contains(analyzer[i]))
                        {
                            loot.Insert(0, analyzer[i]);
                        }
                    }
                    break;
                case "Drop":
                    if (int.Parse(analyzer[1]) >= 0 && int.Parse(analyzer[1]) < loot.Count)
                    {
                        string removedLoot = loot[int.Parse(analyzer[1])];
                        loot.RemoveAt(int.Parse(analyzer[1]));
                        loot.Add(removedLoot);
                    }
                    break;
                case "Steal":
                    int toSteal = int.Parse(analyzer[1]);
                    if (toSteal >= loot.Count)
                    {
                        Console.WriteLine(string.Join(", ", loot));
                        loot.RemoveRange(0, loot.Count);
                    }
                    else
                    {
                        List<string> removed = new();
                        removed.AddRange(loot.Skip(loot.Count - toSteal).Take(toSteal));
                        loot.RemoveRange(loot.Count - toSteal, toSteal);
                        Console.WriteLine(string.Join(", ", removed));
                    }
                    break;
            }
        }
        if (loot.Count == 0) Console.WriteLine("Failed treasure hunt.");
        else
        {
            int sum = 0;
            for (int i = 0; i < loot.Count; i++)
            {
                sum += loot[i].Length;
            }
            Console.WriteLine($"Average treasure gain: {(double)sum / loot.Count:f2} pirate credits.");
        }
    }
}