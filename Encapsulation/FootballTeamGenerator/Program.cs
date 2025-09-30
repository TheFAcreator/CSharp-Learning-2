using FootballTeamGenerator;

List<Team> teams = new();

string input;
while((input = Console.ReadLine()) != "END")
{
    string[] analyzer = input.Split(';', StringSplitOptions.RemoveEmptyEntries);

    switch (analyzer[0])
    {
        case "Team":
            try
            {
                Team team = new(analyzer[1]);
                teams.Add(team);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case "Add":
            try
            {
                string teamName = analyzer[1];
                string playerName = analyzer[2];
                int endurance = int.Parse(analyzer[3]);
                int sprint = int.Parse(analyzer[4]);
                int dribble = int.Parse(analyzer[5]);
                int passing = int.Parse(analyzer[6]);
                int shooting = int.Parse(analyzer[7]);

                Team team = teams.FirstOrDefault(t => t.Name == teamName);
                if (team == null)
                {
                    throw new InvalidOperationException($"Team {teamName} does not exist.");
                }
                
                Player player = new(playerName, endurance, sprint, dribble, passing, shooting);
                team.AddPlayer(player);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case "Remove":
            try
            {
                string teamName = analyzer[1];
                string playerName = analyzer[2];

                Team team = teams.FirstOrDefault(t => t.Name == teamName);
                if (team != null)
                {
                    team.RemovePlayer(playerName);
                }
                else
                {
                    throw new InvalidOperationException($"Team {teamName} does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case "Rating":
            try
            {
                string teamName = analyzer[1];

                Team team = teams.FirstOrDefault(t => t.Name == teamName);
                if (team != null)
                {
                    Console.WriteLine($"{team.Name} - {team.Rating}");
                }
                else
                {
                    throw new InvalidOperationException($"Team {teamName} does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
    }
}