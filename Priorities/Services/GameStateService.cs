using System;
using Priorities.Models;

namespace Priorities.Services
{
	public class GameStateService : IGameStateService
	{
		public GameStateService()
		{

			Players = new();

		}

		public List<Player> Players { get; set; }

		public int Score { get; set; }

		public int Round { get; set; }
		public int TotalRounds { get; set;}

		public TimeSpan TimeElapsed { get; set; }

		public List<string> PlayerRankings { get; set; }
		public List<string> GroupRankings { get; set; }

		public Player Prioritizer { get; set; }

		public Player Guesser { get; set; }

		public GamePhase Phase { get; set; }

	}
}