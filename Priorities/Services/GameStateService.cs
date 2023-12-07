using System;
using System.Collections.ObjectModel;
using Priorities.Models;

namespace Priorities.Services
{
	public class GameStateService : IGameStateService
	{
		public GameStateService()
		{

			Players = new();
			Achievements = new();
			GenerateAchievements();
            

        }

		public void GenerateAchievements()
		{
            Achievements.Add(new Achievement() { Title = "Snail's Pace", Description = "Finish guessing with fewer than 5 seconds left in a round", Image = "snails.svg" });
            Achievements.Add(new Achievement() { Title = "Great Start", Description = "Finish 1 game", Image = "thumbup.svg" });
            Achievements.Add(new Achievement() { Title = "Twinsies", Description = "Have 2 people with the same username in a game", Image = "twins.svg" });
            Achievements.Add(new Achievement() { Title = "Ragnarok", Description = "End the game with 0 points", Image = "bombs.svg" });
            Achievements.Add(new Achievement() { Title = "Open Books", Description = "Finish a game with a perfect score", Image = "book.svg" });
            Achievements.Add(new Achievement() { Title = "Frequent Guesser", Description = "Finish 3 games with over 300 points in each game", Image = "glasses.svg" });
            Achievements.Add(new Achievement() { Title = "Speedster", Description = "Finish guessing with over 100 seconds left in a round", Image = "fast.svg" });
            Achievements.Add(new Achievement() { Title = "Perfectionist", Description = "Get a perfect score in a round", Image = "trophy.svg" });
            Achievements.Add(new Achievement() { Title = "Rockstar", Description = "Get 3 achievements in a game", Image = "stars.svg" });
            Achievements.Add(new Achievement() { Title = "Hooked In", Description = "Play 10 games", Image = "fishhook.svg" });
            Achievements.Add(new Achievement() { Title = "Devil's Advocate", Description = "Get a score of 666", Image = "devil.svg" });
            Achievements.Add(new Achievement() { Title = "Streaker", Description = "Play a game every day for a week", Image = "flames.svg" });
            Achievements.Add(new Achievement() { Title = "Out of Luck", Description = "Get every guess wrong in a game", Image = "horseshoe.svg" });
            Achievements.Add(new Achievement() { Title = "Friendly Neighbor", Description = "Play a game with at least 10 people", Image = "heart.svg" });
            Achievements.Add(new Achievement() { Title = "Mogi Master", Description = "Unlock all achievements", Image = "winner.svg" });

        }

		public List<Player> Players { get; set; }

		public int Score { get; set; }


		public List<Achievement> Achievements { get; set; }

        public int Round { get; set; }
		public int TotalRounds { get; set;}

		public TimeSpan TimeElapsed { get; set; }

		public List<string> PrioritizerRankings { get; set; }
		public List<string> GuesserRankings { get; set; }

		public Player Prioritizer { get; set; }

		public Player Guesser { get; set; }

		public GamePhase Phase { get; set; }

		public List<string> GetRandomItems(int number)
		{
			return new List<string>();
		}

	}
}