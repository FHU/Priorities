
using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;

namespace Priorities.ViewModels
{
    public partial class GetReadyPageViewModel : ObservableObject
    {

        [ObservableProperty]
        Player currentPlayer;

        public ObservableCollection<Player> Players { get; set; }




        public GetReadyPageViewModel()
        {
            Players = new ObservableCollection<Player>
            {
                new Player{Name="Kenan", ImageName="kenan.jpg"},
                new Player{Name="David", ImageName="shannon.jpg"},
                new Player{Name="TJ", ImageName="tj.jpg"}
            };

            var playerCurrent = Players[2];
            CurrentPlayer = playerCurrent;


        }
    }
}