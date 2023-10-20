using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;

namespace Priorities.ViewModels
{
	public class PlayersPageViewModel: ObservableObject 
	{
		public ObservableCollection<Player> Players { get; set; }



		public PlayersPageViewModel()
		{
		}
	}
}

