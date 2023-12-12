using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Priorities.Views;
using System.Collections.ObjectModel;
using Priorities.Models;
using Priorities.Services;

namespace Priorities.ViewModels
{
    public partial class PlayersPageViewModel : ObservableObject
    {
        private readonly IGameStateService gameStateService;

        [ObservableProperty]
        bool hasEnoughPlayers = false;

        [ObservableProperty]
        bool hasTooFewPlayers = true;

        public ObservableCollection<Player> Players { get; set; } = new();

        public Command NavigateToAddPlayersPageCommand { get; }
        public Command NavigateToGamePageCommand { get; }

        public Command DeleteButtonCommand { get; private set; }

        public PlayersPageViewModel(IGameStateService gameStateService)
        {
            this.gameStateService = gameStateService;

            LoadData();

            NavigateToAddPlayersPageCommand = new Command(async () => await NavigateToAddPlayersPage());
            NavigateToGamePageCommand = new Command(async () => await NavigateToGamePage());
            DeleteButtonCommand = new Command<Player>(DeletePlayer);


            gameStateService.PrioritizerIndex = 0;
            gameStateService.GuesserIndex = gameStateService.PrioritizerIndex + 1;
        }


        public void LoadData()
        {
            Players.Clear();

            foreach (Player p in gameStateService.Players)
            {
                Players.Add(p);
            }

            updateHasEnoughPlayers();
        }


        private async Task NavigateToAddPlayersPage()
        {
            //gameStateService.Players.Add( new Player() { Name=PlayerName, ImageName=ImagePath};

            // Use Shell.Current.GoToAsync() to navigate to the AddPlayersPage
            await Shell.Current.GoToAsync($"{nameof(AddPlayerPage)}");
        }
        private async Task NavigateToGamePage()
        {
            // Use Shell.Current.GoToAsync() to navigate to the AddPlayersPage
            gameStateService.TotalRounds = gameStateService.Players.Count;
            await Shell.Current.Navigation.PushAsync(new GetReadyPage(gameStateService));
        }

        [RelayCommand]
        void DeletePlayer(Player player)
        {
            Players.Remove(player);
            gameStateService.Players.Remove(player);
            updateHasEnoughPlayers();
        }

        private void updateHasEnoughPlayers()
        {
            if(Players.Count > 1 && gameStateService.Players.Count > 1)
            {
                HasEnoughPlayers = true;
                HasTooFewPlayers = false;
            }
            else
            {
                HasEnoughPlayers = false;
                HasTooFewPlayers = true;
            }
        }
    }
}
