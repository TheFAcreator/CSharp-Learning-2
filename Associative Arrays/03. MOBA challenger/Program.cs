public class Program
{
    static void Main()
    {
        string input = "";
        Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
        while ((input = Console.ReadLine()) != "Season end")
        {
            string[] analyzer = input.Split();
            if (analyzer[1] == "->")
            {
                string name = analyzer[0];
                string technique = analyzer[2];
                int skill = int.Parse(analyzer[4]);
                if (!players.ContainsKey(name))
                {
                    players.Add(name, new Dictionary<string, int>());
                    players[name].Add(technique, skill);
                }
                else
                {
                    if (!players[name].ContainsKey(technique))
                    {
                        players[name].Add(technique, skill);
                    }
                    else
                    {
                        if (players[name][technique] < skill)
                        {
                            players[name][technique] = skill;
                        }
                    }
                }
            }
            else if (analyzer[1] == "vs")
            {
                string player1 = analyzer[0];
                string player2 = analyzer[2];
                if (players.ContainsKey(player1) && players.ContainsKey(player2))
                {
                    foreach (var item in players[player1])
                    {
                        if (players[player2].ContainsKey(item.Key))
                        {
                            if (players[player1].Values.Sum() > players[player2].Values.Sum())
                            {
                                players.Remove(player2);
                            }
                            else if (players[player1].Values.Sum() < players[player2].Values.Sum())
                            {
                                players.Remove(player1);
                            }
                            break;
                        }
                    }
                }
            }
        }
        foreach (var player in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
            foreach (var item in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"- {item.Key} <::> {item.Value}");
            }
        }
    }
}