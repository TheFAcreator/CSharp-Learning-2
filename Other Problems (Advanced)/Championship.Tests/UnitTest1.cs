namespace Championship.Tests
{
    using NUnit.Framework;
    using System;
    public class Tests
    {

        // Arrange
        League league;
        [SetUp]
        public void Setup()
        {
            league = new();
        }

        [Test]
        public void Constructor_ShouldInitializeLeagueWithEmptyTeamsListAndCapacity()
        {
            // Assert
            Assert.IsNotNull(league.Teams);
            Assert.AreEqual(0, league.Teams.Count);
            Assert.AreEqual(10, league.Capacity);
        }

        [Test]
        public void AddTeam_ShouldAddTeam()
        {
            // Arrange
            Team team = new("Team A");
            // Act
            league.AddTeam(team);
            // Assert
            Assert.AreEqual(1, league.Teams.Count);
            Assert.AreEqual("Team A", league.Teams[0].Name);
        }

        [Test]
        public void AddTeam_ShouldThrowExceptionWhenLeagueIsFull()
        {
            // Arrange
            for (int i = 0; i < 10; i++)
            {
                league.AddTeam(new Team($"Team {i + 1}"));
            }
            Team newTeam = new("New Team");
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => league.AddTeam(newTeam), "League is full.");
        }

        [Test]
        public void AddTeam_ShouldThrowExceptionWhenTeamAlreadyExists()
        {
            // Arrange
            Team team = new("Team A");
            league.AddTeam(team);
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => league.AddTeam(new Team("Team A")), "Team already exists.");
        }

        [Test]
        public void RemoveTeam_ShouldRemoveTeam()
        {
            // Arrange
            Team team = new("Team A");
            league.AddTeam(team);
            // Act
            bool result = league.RemoveTeam("Team A");
            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(0, league.Teams.Count);
        }

        [Test]
        public void RemoveTeam_ShouldReturnFalseIfTeamDoesNotExist()
        {
            // Act
            bool result = league.RemoveTeam("Team A");
            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void PlayMatch_ShouldUpdateTeamsAfterMatchWhenHomeTeamWins()
        {
            // Arrange
            Team homeTeam = new("Home Team");
            Team awayTeam = new("Away Team");
            league.AddTeam(homeTeam);
            league.AddTeam(awayTeam);
            // Act
            league.PlayMatch("Home Team", "Away Team", 2, 1);
            // Assert
            Assert.AreEqual(1, homeTeam.Wins);
            Assert.AreEqual(1, awayTeam.Loses);
            Assert.AreEqual(3, homeTeam.Points);
        }

        [Test]
        public void PlayMatch_ShouldUpdateTeamsWhenAwayTeamWins()
        {
            Team homeTeam = new("Home Team");
            Team awayTeam = new("Away Team");
            league.AddTeam(homeTeam);
            league.AddTeam(awayTeam);

            league.PlayMatch("Home Team", "Away Team", 1, 2);

            Assert.AreEqual(1, awayTeam.Wins);
            Assert.AreEqual(1, homeTeam.Loses);
            Assert.AreEqual(3, awayTeam.Points);
        }


        [Test]
        public void PlayMatch_ShouldUpdateTeamsAfterMatchWhenDraw()
        {
            // Arrange
            Team homeTeam = new("Home Team");
            Team awayTeam = new("Away Team");
            league.AddTeam(homeTeam);
            league.AddTeam(awayTeam);
            // Act
            league.PlayMatch("Home Team", "Away Team", 2, 2);
            // Assert
            Assert.AreEqual(1, homeTeam.Draws);
            Assert.AreEqual(1, awayTeam.Draws);
        }

        [Test]
        public void PlayMatch_ShouldThrowExceptionIfTeamsDoNotExist()
        {
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => league.PlayMatch("Nonexistent Team", "Another Team", 1, 0), "One or both teams do not exist.");
        }

        [Test]
        public void GetTeamInfo_ShouldReturnCorrectTeamInfo()
        {
            // Arrange
            Team team = new("Team A");
            league.AddTeam(team);
            team.Win();
            team.Draw();
            // Act
            string teamInfo = league.GetTeamInfo("Team A");
            // Assert
            Assert.AreEqual("Team A - 4 points (1W 1D 0L)", teamInfo);
        }

        [Test]
        public void GetTeamInfo_ShouldThrowExceptionIfTeamDoesNotExist()
        {
            // Assert
            Assert.Throws<InvalidOperationException>(() => league.GetTeamInfo("Nonexistent Team"), "Team does not exist.");
        }
    }
}