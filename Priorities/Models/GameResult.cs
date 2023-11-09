using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;

namespace Priorities.Models
{
	public class GameResult
	{
		public int Rank { get; set; }
		public Team Team { get; set; }
		public int Score { get; set; }
		public DateTime Date { get; set; }
		public ObservableCollection<Achievement> Achievements { get; set; }
		public GameResult()
		{

		}
	}
}

