﻿using System;
using System.Collections.ObjectModel;
using Priorities.Models;

namespace Priorities.Services
{
    public enum GamePhase
    {
        Prioritizing,
        Guessing
    }

    public interface IGameStateService
	{
        public List<Player> Players { get; set; }
        public int Score { get; set; }

        public List<Achievement> Achievements { get; set; }

        public int Round { get; set; }
        public int TotalRounds { get; set; }

        public TimeSpan TimeElapsed { get; set; }

        public List<string> PrioritizerRankings { get; set; }
        public List<string> GuesserRankings { get; set; }

        public Player Prioritizer { get; set; }

        public Player Guesser { get; set; }

        public int PrioritizerIndex { get; set; }

        public int GuesserIndex { get; set; }

        public GamePhase Phase { get; set; }

        public List<string> GetRandomItems();
    }
}

