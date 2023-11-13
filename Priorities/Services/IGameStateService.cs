using System;
using Priorities.Models;

namespace Priorities.Services
{
	public interface IGameStateService
	{
        public List<Player> Players { get; set; }
        public int Score { get; set; }

        public int Round { get; set; }
        public int TotalRounds { get; set; }

    }
}

