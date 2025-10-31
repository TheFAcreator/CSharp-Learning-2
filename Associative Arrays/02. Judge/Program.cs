public class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
        Dictionary<string, Dictionary<string, int>> users = new();
        string input = "";
        while ((input = Console.ReadLine()) != "no more time")
        {
            string[] analyzer = input.Split(" -> ");
            string username = analyzer[0];
            string contest = analyzer[1];
            int points = int.Parse(analyzer[2]);
            if (!contests.ContainsKey(contest))
            {
                contests.Add(contest, new Dictionary<string, int>());
                contests[contest].Add(username, points);
            }
            else
            {
                if (!contests[contest].ContainsKey(username))
                {
                    contests[contest].Add(username, points);
                }
                else
                {
                    if (contests[contest][username] < points)
                    {
                        contests[contest][username] = points;
                    }
                }
            }
            if (!users.ContainsKey(username))
            {
                users.Add(username, new Dictionary<string, int>());
                users[username].Add(contest, points);
            }
            else
            {
                if (!users[username].ContainsKey(contest))
                {
                    users[username].Add(contest, points);
                }
                else
                {
                    if (users[username][contest] < points)
                    {
                        users[username][contest] = points;
                    }
                }
            }
        }
        foreach (var contest in contests)
        {
            Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
            int count = 1;
            foreach (var user in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{count}. {user.Key} <::> {user.Value}");
                count++;
            }
        }
        Console.WriteLine("Individual standings:");
        int counter = 1;
        foreach (var user in users.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{counter}. {user.Key} -> {user.Value.Values.Sum()}");
            counter++;
        }
    }
}