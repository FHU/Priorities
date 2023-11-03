﻿using System;
using System.Collections.ObjectModel;
using Priorities.Models;

namespace Priorities.Models
{
	public class GameResult
	{
		public Team Team { get; set; }
		public int Score { get; set; }
		public DateTime Date { get; set; }
		public ObservableCollection<Achievement> Achievements { get; set; }
		public GameResult()
		{
		}
	}
}

