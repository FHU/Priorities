using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Security.Cryptography;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Priorities.Models;
using Priorities.Views;

namespace Priorities.ViewModels
{
    public partial class PlayersPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string playerName;

        [ObservableProperty]
        private string imagePath;

        public ObservableCollection<Player> Players { get; set; }
        public Command NavigateToAddPlayersPageCommand { get; }
        public Command NavigateToGamePageCommand { get; }
        public class Player
        {
            public string PlayerName { get; set; }
            public string ImagePath { get; set; }

        }
        public PlayersPageViewModel()
        { 
            var p1 = new Player();
            playerName = "Addison";
            imagePath = "rando1.jpg";
            NavigateToAddPlayersPageCommand = new Command(async () => await NavigateToAddPlayersPage());
            NavigateToGamePageCommand = new Command(async () => await NavigateToGamePage());
            //Players.Add(new Player { PlayerName = "Addison", ImagePath = "rando1.jpg" });
            //Players.Add(new Player { PlayerName = "John", ImagePath = "rando2.jpg" });

        }

        private async Task NavigateToAddPlayersPage()
        {
            // Use Shell.Current.GoToAsync() to navigate to the AddPlayersPage
            await Shell.Current.GoToAsync($"{nameof(AddPlayerPage)}");
        }
        private async Task NavigateToGamePage()
        {
            // Use Shell.Current.GoToAsync() to navigate to the AddPlayersPage
            await Shell.Current.GoToAsync($"{nameof(GamePage)}");
        }
    }
}