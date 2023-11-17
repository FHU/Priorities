
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
            Players = new ObservableCollection<Player>()
            {
                new Player() { Name = "Kenan", ImageName = "kenan.jpeg" },
                new Player() { Name = "Bot", ImageName = "avatar_pic.jpg" }
            };

            CurrentPlayer = Players[0];

            Console.WriteLine(CurrentPlayer.ImageName);
        }
    }
}