using System;
namespace Priorities.Models
{
	public class GameResult
	{
		public Team Team { get; set; }
		public int Score { get; set; }

		public DateTime Date { get; set; }

		public GameResult()
		{
		}
	}
}

