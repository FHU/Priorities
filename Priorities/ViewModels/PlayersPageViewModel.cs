using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Priorities.Models;
using Priorities.Views;

namespace Priorities.ViewModels
{
    public partial class PlayersPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string playerName;

        [ObservableProperty]
        string imagePath;

        public ObservableCollection<Player> Players { get; set; }

        public Command NavigateToAddPlayersPageCommand { get; }
        public Command NavigateToGamePageCommand { get; }

        public Command DeleteButtonCommand { get; private set; }

        public class Player
        {
            public string PlayerName { get; set; }

            public string ImagePath { get; set; }

            public Player() 
            { 
            }

        }

        public PlayersPageViewModel()
        {
            Players = new ObservableCollection<Player>
        {
            new Player{PlayerName="Joe", ImagePath="rando1.jpg"},
            new Player{PlayerName="Mo", ImagePath="rando2.jpg"},
            new Player{PlayerName="Shmo", ImagePath="rando3.jpg"},
            new Player { PlayerName = "Tractor", ImagePath = "rando4.jpg" },
            new Player{PlayerName="Joe", ImagePath="rando1.jpg"},
            new Player{PlayerName="Mo", ImagePath="rando2.jpg"},
            new Player{PlayerName="Shmo", ImagePath="rando3.jpg"},
            new Player { PlayerName = "Tractor", ImagePath = "rando4.jpg" },

        };



            NavigateToAddPlayersPageCommand = new Command(async () => await NavigateToAddPlayersPage());
            NavigateToGamePageCommand = new Command(async () => await NavigateToGamePage());
            DeleteButtonCommand = new Command<Player>(DeletePlayer);
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

        [RelayCommand]
        void DeletePlayer(Player player)
        {
            if (Players.Contains(player))
            {
                Players.Remove(player);
            }
        }
    }
}
