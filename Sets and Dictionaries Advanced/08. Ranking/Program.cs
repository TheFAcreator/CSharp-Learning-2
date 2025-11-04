Dictionary<string, string> contests = new();
string input = "";

while ((input = Console.ReadLine()) != "end of contests")
{
    string[] analyzer = input.Split(':');
    string contest = analyzer[0];
    string password = analyzer[1];
    contests[contest] = password;
}

Dictionary<string, Dictionary<string, int>> submissions = new();

while((input = Console.ReadLine()) != "end of submissions")
{
    string[] analyzer = input.Split("=>");
    string contest = analyzer[0];
    string password = analyzer[1];
    string username = analyzer[2];
    int points = int.Parse(analyzer[3]);
    if (contests.ContainsKey(contest) && contests[contest] == password)
    {
        if (!submissions.ContainsKey(username))
        {
            submissions[username] = new();
        }
        if (!submissions[username].ContainsKey(contest))
        {
            submissions[username][contest] = 0;
        }
        if (submissions[username][contest] < points)
        {
            submissions[username][contest] = points;
        }
    }
}

var bestCandidate = submissions.OrderByDescending(x => x.Value.Values.Sum()).FirstOrDefault();
Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCandidate.Value.Values.Sum()} points.");

Console.WriteLine("Ranking:");
foreach (var kvp in submissions.OrderBy(x => x.Key))
{
    Console.WriteLine(kvp.Key);
    foreach (var kvp2 in kvp.Value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {kvp2.Key} -> {kvp2.Value}");
    }
}