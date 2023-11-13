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

		//public List<Player> GetPlayers()
		//{


		//	return Players;
		//}

		//public void AddPlayer(Player player)
		//{
		//	Players.Add(player);
		//}

		public int Score { get; set; }

		//public int GetScore()
		//{
		//	return Score;
		//}

		//public void SetScore()
		//{

		//}

		public int Round { get; set; }
		public int TotalRounds
		{
			get; set;

		}
	}
}