using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;
using CommunityToolkit.Mvvm.Input;
using Priorities.Views;
using Priorities.Services;

namespace Priorities.ViewModels
{
    public partial class RoundResultsPageViewModel : ObservableObject
    {
        private readonly IGameStateService gameStateService;

        [ObservableProperty]
        private int round;

        [ObservableProperty]
        private int totalRounds;

        [ObservableProperty]
        private int score;

        [ObservableProperty]
        private Player person;

        private List<string> PlayerRanking { get; set; }

        private List<string> GroupRanking { get; set; }

        public ObservableCollection<Ranking> Rankings { get; set; }

        public RoundResultsPageViewModel(IGameStateService gameStateService)
        {
            string i1 = "Giraffe";
            string i2 = "Chocolate";
            string i3 = "Fruit";
            string i4 = "Sleep";
            string i5 = "Casey";

            this.gameStateService = gameStateService; // MADISON DON'T DELETE THIS LINE

            this.gameStateService.Score = 0;
            this.gameStateService.Round = 1;
            this.gameStateService.TotalRounds = 10;
            this.gameStateService.PlayerRankings = new List<string> { i1, i2, i3, i4, i5 };
            //this.gameStateService.PrioritizerRankings = new List<string> { i1, i2, i3, i4, i5 };
            this.gameStateService.GroupRankings = new List<string> { i1, i4, i3, i2, i5 };
            //this.gameStateService.GuesserRankings = new List<string> { i1, i4, i3, i2, i5 };
            this.gameStateService.CurrentPlayer = new Player() { Name = "K-Dawg", ImageName = "kenan.jpeg" };
            //this.gameStateService.Prioritizer = new Player() { Name = "K-Dawg", ImageName = "kenan.jpeg" };

            Round = this.gameStateService.Round;
            TotalRounds = this.gameStateService.TotalRounds;
            Score = this.gameStateService.Score;
            Person = this.gameStateService.CurrentPlayer;
            //Person = this.gameStateService.Prioritizer;
            PlayerRanking = this.gameStateService.PlayerRankings;
            //PlayerRanking = this.gameStateService.PrioritizerRankings;
            GroupRanking = this.gameStateService.GroupRankings;
            //GroupRanking = this.gameStateService.GuesserRankings;

            Rankings = new ObservableCollection<Ranking>();
        }

        public void GetResult(int rank)
        {
            Ranking ranking = new Ranking() { Number = rank, Name = GroupRanking[rank - 1] };

            if (GroupRanking[rank - 1] == PlayerRanking[rank - 1])
            {
                ranking.Points = 25 - (5 * (rank - 1));
                ranking.Color = Color.FromArgb("#74C1DD");
                Score += ranking.Points;
            }
            else
            {
                ranking.Points = -1 * (25 - (5 * (rank - 1)));
                ranking.Color = Color.FromArgb("#EC6664");
                Score += ranking.Points;
            }

            Rankings.Insert(0, ranking);
        }

        [RelayCommand]
        void Next()
        {
            // update game state service
            gameStateService.Score = Score;
            gameStateService.PlayerRankings.Clear();
            //gameStateService.PrioritizerRankings.Clear();
            gameStateService.GroupRankings.Clear();
            //gameStateService.GuesserRankings.Clear();

            if (Round == TotalRounds)
            {
                // go to game over page
                Shell.Current.GoToAsync($"{nameof(GameResultsPage)}");
            }
            else
            {
                // update round
                //Round++;

                // update game state service round
                //gameStateService.Round = Round;

                // pass to next player
                Shell.Current.GoToAsync($"{nameof(GetReadyPage)}");
            }
        }

        [RelayCommand]
        async Task ShowRankings()
        {
            for (int i = 5; i > 0; i--)
            {
                await Task.Delay(1000);
                GetResult(i);
            }
        }

    }


}
