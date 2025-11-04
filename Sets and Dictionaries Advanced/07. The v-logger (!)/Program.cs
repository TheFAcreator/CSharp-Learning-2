class Vlogger
{
    public HashSet<string> Followers { get; set; } = new();
    public HashSet<string> Following { get; set; } = new();
}
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Vlogger> vloggers = new();

        string input = "";
        while((input = Console.ReadLine()) != "Statistics")
        {
            string[] analyzer = input.Split();
            string vlogger1 = analyzer[0];
            string command = analyzer[1];
            if(command == "joined")
            {
                if (!vloggers.ContainsKey(vlogger1))
                {
                    vloggers[vlogger1] = new Vlogger();
                }
            }
            else if (command == "followed")
            {
                string vlogger2 = analyzer[2];
                if (vloggers.ContainsKey(vlogger1) && vloggers.ContainsKey(vlogger2) && vlogger1 != vlogger2)
                {
                    vloggers[vlogger1].Following.Add(vlogger2);
                    vloggers[vlogger2].Followers.Add(vlogger1);
                }
            }
        }

        Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

        int count = 1;
        foreach (var kvp in vloggers.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Following.Count))
        {
            Console.WriteLine($"{count++}. {kvp.Key} : {kvp.Value.Followers.Count} followers, {kvp.Value.Following.Count} following");
            if (count == 2)
            {
                foreach (var follower in kvp.Value.Followers.OrderBy(x => x))
                {
                    Console.WriteLine($"*  {follower}");
                }
            }
        }
    }
}