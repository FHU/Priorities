using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Priorities.Models;
using Priorities.Services;

namespace Priorities.ViewModels
{
    public partial class PlayersPageViewModel : ObservableObject
    {
		private readonly IGameStateService gameStateService;


        public ObservableCollection<Player> Players { get; set; }

		public PlayersPageViewModel(IGameStateService gameStateService)
		{
			this.gameStateService = gameStateService;

			Players = new();

            LoadData();
        }


        //[RelayCommand]
        //private void LoadData()
        //{
        //    foreach (var player in gameStateService.Players)
        //    {
        //        Players.Add(player);
        //    }
        //}

        public void LoadData()
        {
            Players.Clear();

            foreach (var player in gameStateService.Players)
            {
                Players.Add(player);
            }
        }


    }
}

