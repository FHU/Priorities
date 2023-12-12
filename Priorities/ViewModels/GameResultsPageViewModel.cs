using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;
using Priorities.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Priorities.Services;

namespace Priorities.ViewModels
{
    
    internal partial class GameResultsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        //public int Score { get; set; }
        int score;
        [ObservableProperty]
        //public TimeSpan ElapsedTime { get; set; }
        TimeSpan elapsedTime;
        private IGameStateService gameStateService;

        public Command NavigateToPlayersPageCommand { get; }
        public Command NavigateToHighScorePageCommand { get; }
        public Command NavigateToHomePageCommand { get; }


        public ObservableCollection<Achievement> Achievements { get; set; }

        private async Task NavigateToPlayersPage()
        {
            // Use Shell.Current.GoToAsync() to navigate to the AddPlayersPage
            await Shell.Current.GoToAsync($"{nameof(PlayersPage)}");
        }

        private async Task NavigateToHighScorePage()
        {
            // Use Shell.Current.GoToAsync() to navigate to the AddPlayersPage
            await Shell.Current.GoToAsync($"{nameof(HighScorePage)}");
        }

        private async Task NavigateToHomePage()
        {
            // Use Shell.Current.GoToAsync() to navigate to the AddPlayersPage
            await Shell.Current.GoToAsync($"{nameof(HomePage)}");
        }

        /// <summary>
        /// 
        /// </summary>
        public GameResultsPageViewModel(IGameStateService gameStateService) 
        {

            this.gameStateService = gameStateService;

            Score = gameStateService.Score;
            ElapsedTime = new TimeSpan(0, 30, 25);
            Achievements = new ObservableCollection<Achievement>();

            var achievement = new Achievement();
            achievement.Title = "Great Start";

            

            var achievement2 = new Achievement();
            achievement2.Title = "Fastest Man Alive";
            

            var achievement3 = new Achievement();
            achievement3.Title = "Snail's Pace";
            

            Achievements.Add(achievement);
            Achievements.Add(achievement2);
            Achievements.Add(achievement3);


            NavigateToPlayersPageCommand = new Command(async () => await NavigateToPlayersPage());
            NavigateToHighScorePageCommand = new Command(async () => await NavigateToHighScorePage());
            NavigateToHomePageCommand = new Command(async () => await NavigateToHomePage());


            gameStateService.Score = 0;
            gameStateService.Round = 1;



        }



    }
}
