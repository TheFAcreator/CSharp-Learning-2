using FootballManager.Core.Contracts;
using FootballManager.Models;
using FootballManager.Models.Contracts;
using FootballManager.Repositories;
using System.Text;

namespace FootballManager.Core
{
    public class Controller : IController
    {
        private TeamRepository championship = new TeamRepository();

        public string ChampionshipRankings()
        {
            StringBuilder rankings = new();
            rankings.AppendLine("***Ranking Table***");

            int rank = 1;
            foreach (var team in championship.Models.OrderByDescending(t => t.ChampionshipPoints).ThenByDescending(t => t.PresentCondition))
            {
                rankings.AppendLine($"{rank++}. {team}/{team.TeamManager}");
            }

            return rankings.ToString().TrimEnd();
        }

        public string JoinChampionship(string teamName)
        {
            if (championship.Models.Count >= 10)
            {
                return "Championship is full!";
            }
            if (championship.Exists(teamName))
            {
                return $"{teamName} has already joined the Championship.";
            }
            championship.Add(new Team(teamName));
            return $"{teamName} has successfully joined the Championship.";
        }

        public string MatchBetween(string teamOneName, string teamTwoName)
        {
            if (!championship.Exists(teamOneName) || !championship.Exists(teamTwoName))
            {
                return "This match does not meet the regulation rules of the Championship.";
            }
            var teamOne = championship.Get(teamOneName);
            var teamTwo = championship.Get(teamTwoName);

            var conditionOne = teamOne.PresentCondition;
            var conditionTwo = teamTwo.PresentCondition;

            if (conditionOne > conditionTwo)
            {
                teamOne.GainPoints(3);

                teamTwo.TeamManager?.RankingUpdate(-5);
                teamOne.TeamManager?.RankingUpdate(5);

                return $"Team {teamOneName} wins the match against {teamTwoName}.";
            }
            else if (conditionOne < conditionTwo)
            {
                teamTwo.GainPoints(3);

                teamTwo.TeamManager?.RankingUpdate(5);
                teamOne.TeamManager?.RankingUpdate(-5);

                return $"Team {teamTwoName} wins the match against {teamOneName}.";
            }
            else
            {
                teamOne.GainPoints(1);
                teamTwo.GainPoints(1);

                return $"The match between {teamOneName} and {teamTwoName} ends in a draw.";
            }
        }

        public string PromoteTeam(string droppingTeamName, string promotingTeamName, string managerTypeName, string managerName)
        {
            if (!championship.Exists(droppingTeamName))
            {
                return $"Team {droppingTeamName} does not exist in the Championship.";
            }
            if (championship.Exists(promotingTeamName))
            {
                return $"{promotingTeamName} has already joined the Championship.";
            }

            Team promotingTeam = new(promotingTeamName);

            if (!championship.Models.Any(m => m.TeamManager != null && m.TeamManager.Name == managerName))
            {
                IManager manager = null;
                if (managerTypeName == nameof(AmateurManager))
                    manager = new AmateurManager(managerName);
                else if (managerTypeName == nameof(ProfessionalManager))
                    manager = new ProfessionalManager(managerName);
                else if (managerTypeName == nameof(SeniorManager))
                    manager = new SeniorManager(managerName);

                if (manager != null)
                    promotingTeam.SignWith(manager);
            }

            championship.Remove(droppingTeamName);
            championship.Add(promotingTeam);

            foreach (var team in championship.Models)
            {
                team.ResetPoints();
            }

            return $"Team {promotingTeamName} wins a promotion for the new season.";
        }

        public string SignManager(string teamName, string managerTypeName, string managerName)
        {
            IManager manager = null;
            if (managerTypeName == nameof(AmateurManager))
                manager = new AmateurManager(managerName);
            else if (managerTypeName == nameof(ProfessionalManager))
                manager = new ProfessionalManager(managerName);
            else if (managerTypeName == nameof(SeniorManager))
                manager = new SeniorManager(managerName);

            if (!championship.Exists(teamName))
            {
                return $"Team {teamName} does not take part in the Championship.";
            }
            if (manager == null)
            {
                return $"{managerTypeName} is an invalid manager type for the application.";
            }
            if (championship.Get(teamName).TeamManager != null)
            {
                return $"Team {teamName} has already signed a contract with {championship.Get(teamName).TeamManager.Name}.";
            }

            foreach (var team in championship.Models)
            {
                if (team.TeamManager != null && team.TeamManager.Name == managerName)
                {
                    return $"Manager {managerName} is already assigned to another team.";
                }
            }
            championship.Get(teamName).SignWith(manager);

            return $"Manager {managerName} is assigned to team {teamName}.";
        }
    }
}
