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

            /* Delete these lines later */
            this.gameStateService.Score = 0;
            this.gameStateService.Round = 1;
            this.gameStateService.TotalRounds = 10;
            this.gameStateService.PlayerRankings = new List<string> { i1, i2, i3, i4, i5 };
            this.gameStateService.GroupRankings = new List<string> { i1, i2, i4, i3, i5 };
            this.gameStateService.Prioritizer = new Player() { Name = "K-Dawg", ImageName = "kenan.jpeg" };


            /* KEEP THESE LINES */
            this.Round = this.gameStateService.Round;
            this.TotalRounds = this.gameStateService.TotalRounds;
            this.Score = this.gameStateService.Score;
            this.Person = this.gameStateService.Prioritizer;
            this.PlayerRanking = this.gameStateService.PlayerRankings;
            this.GroupRanking = this.gameStateService.GroupRankings;

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
            Round++;
            gameStateService.Score = Score;
            gameStateService.Round = Round;
            gameStateService.PlayerRankings.Clear();
            gameStateService.GroupRankings.Clear();
            //this.gameStateService.CurrentPlayer = this.gameStateService.Players[this.gameStateService.Players.IndexOf(this.Person) + 1];
            Shell.Current.GoToAsync($"{nameof(GamePage)}");
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
