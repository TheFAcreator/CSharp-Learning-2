Dictionary<string, string> users = new();
Dictionary<string, HashSet<string>> sides = new();

string input = "";
while((input = Console.ReadLine()) != "Lumpawaroo")
{
    string[] analyzer = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if(analyzer.Contains("|"))
    {
        analyzer = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
        string side = analyzer[0].Trim();
        string user = analyzer[1].Trim();

        if (!users.ContainsKey(user))
        {
            users[user] = side;
        }
        else continue;

        if (!sides.ContainsKey(side))
        {
            sides[side] = new HashSet<string>();
        }

        sides[side].Add(user);
    }
    else
    {
        analyzer = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
        string user = analyzer[0].Trim();
        string side = analyzer[1].Trim();

        if(!sides.ContainsKey(side))
        {
            sides[side] = new HashSet<string>();
        }

        if (!users.ContainsKey(user))
        {
            users[user] = side;
            sides[side].Add(user);
        }
        else
        {
            sides[users[user]].Remove(user);
            sides[side].Add(user);
            users[user] = side;
        }

        Console.WriteLine($"{user} joins the {side} side!");
    }
}

foreach(var kvp in sides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
{
    if (kvp.Value.Count == 0) continue;

    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
    foreach (var user in kvp.Value.OrderBy(x => x))
    {
        Console.WriteLine($"! {user}");
    }
}