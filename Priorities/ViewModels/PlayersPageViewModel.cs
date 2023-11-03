using System;
using System.Collections.ObjectModel;
using System.Reflection;
using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;

namespace Priorities.ViewModels
{
	public class PlayersPageViewModel: ObservableObject 
	{
		public ObservableCollection<Player> Players { get; set; }



		public PlayersPageViewModel()
		{
            Players = new ObservableCollection<Player>();
		}

			//Model
			//Player

			//string Name

			//string ImagePath

			//View Model
			//Properties
			//ObservableCollection<Player> Players

			//Commands
			//AddPlayer()

			//RemovePlayer(Player)

			//EditPlayer(Player)

			//PlayGame()

		public void AddPlayers()
		{
            throw new NotImplementedException();
        }

		public void RemovePlayers()
		{
			throw new NotImplementedException();
		}

		public void EditPlayer()
		{
			throw new NotImplementedException();
		} 

		public void PlayeGame()
		{
			throw new NotImplementedException();
		}

    }
}

