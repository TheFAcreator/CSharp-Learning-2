class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();
        string input = "";
        while ((input = Console.ReadLine()) != "End")
        {
            string[] analyzer = input.Split();
            switch (analyzer[0])
            {
                case "Enroll":
                    if (heroes.ContainsKey(analyzer[1])) Console.WriteLine(analyzer[1] + " is already enrolled.");
                    else heroes[analyzer[1]] = new();
                    break;
                case "Learn":
                    if (isHeroEnrolled(heroes, analyzer[1]))
                    {
                        if (heroes[analyzer[1]].Contains(analyzer[2])) Console.WriteLine(analyzer[1] + " has already learnt " + analyzer[2] + ".");
                        else heroes[analyzer[1]].Add(analyzer[2]);
                    }
                    break;
                case "Unlearn":
                    if (isHeroEnrolled(heroes, analyzer[1]))
                    {
                        if (heroes[analyzer[1]].Contains(analyzer[2])) heroes[analyzer[1]].Remove(analyzer[2]);
                        else Console.WriteLine(analyzer[1] + " doesn't know " + analyzer[2] + ".");
                    }
                    break;
            }
        }
        Console.WriteLine("Heroes:");
        foreach (var kvp in heroes) Console.WriteLine("== {0}: {1}", kvp.Key, string.Join(", ", kvp.Value));
    }
    static bool isHeroEnrolled(Dictionary<string, List<string>> heroes, string hero)
    {
        if (heroes.ContainsKey(hero)) return true;
        Console.WriteLine(hero + " doesn't exist.");
        return false;
    }
}