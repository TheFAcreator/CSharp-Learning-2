using System.Collections.Generic;
class Team
{
    public Team(string creator, string name)
    {
        Creator = creator;
        Name = name;
        members = new();
    }
    public string Creator { get; set; }
    public string Name { get; set; }
    public List<string> members;
}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Team> teams = new();
        for (int i = 0; i < n; i++)
        {
            string[] analyzer = Console.ReadLine().Split("-");
            if (IsUserExistent(analyzer[0], teams) && IsTeamExisting(analyzer[1], teams))
            {
                teams.Add(new(analyzer[0], analyzer[1]));
                Console.WriteLine($"Team {analyzer[1]} has been created by {analyzer[0]}!");
            }
        }
        string input = "";
        while ((input = Console.ReadLine()) != "end of assignment")
        {
            string[] analyzer = input.Split("->");
            if (IsTeamExistent(analyzer[1], teams) && IsUserExisting(analyzer[0], teams, analyzer[1]))
            {
                Team team = teams.FirstOrDefault(t => t.Name == analyzer[1]);
                if (team != null)
                {
                    team.members.Add(analyzer[0]);
                }
            }
        }
        List<string> disbanded = new();
        teams.RemoveAll(team => {
            if (team.members.Count == 0)
            {
                disbanded.Add(team.Name);
                return true;
            }
            return false;
        });
        teams = teams.OrderByDescending(n => n.members.Count).ThenBy(n => n.Name).ToList();
        foreach (Team team in teams)
        {
            team.members.Sort();
            Console.WriteLine(team.Name);
            Console.WriteLine($"- {team.Creator}");
            foreach (string member in team.members)
                Console.WriteLine($"-- {member}");
        }
        Console.WriteLine("Teams to disband:");
        disbanded.Sort();
        foreach (string i in disbanded) Console.WriteLine(i);
    }
    static bool IsTeamExistent(string team, List<Team> teams)
    {
        foreach (Team i in teams)
        {
            if (i.Name == team) return true;
        }
        Console.WriteLine($"Team {team} does not exist!");
        return false;
    }
    static bool IsUserExisting(string user, List<Team> teams, string team)
    {
        if (teams.Any(t => t.members.Contains(user)) || teams.Any(h => h.Creator == user))
        {
            Console.WriteLine($"Member {user} cannot join team {team}!");
            return false;
        }
        return true;
    }
    static bool IsUserExistent(string user, List<Team> users)
    {
        foreach (Team i in users)
        {
            if (i.Creator == user)
            {
                Console.WriteLine($"{user} cannot create another team!");
                return false;
            }
        }
        return true;
    }
    static bool IsTeamExisting(string team, List<Team> teams)
    {
        foreach (Team i in teams)
        {
            if (i.Name == team)
            {
                Console.WriteLine($"Team {team} was already created!");
                return false;
            }
        }
        return true;
    }
}