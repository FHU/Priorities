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
        private bool showNext;

        [ObservableProperty]
        private int round;

        [ObservableProperty]
        private int totalRounds;

        [ObservableProperty]
        private int score;

        [ObservableProperty]
        private Player person;

        private List<string> PrioritizerRankings;

        private List<string> GuesserRankings;

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


            /* KEEP THESE LINES */
            this.Round = this.gameStateService.Round;
            this.TotalRounds = this.gameStateService.TotalRounds;
            this.Score = this.gameStateService.Score;
            this.Person = this.gameStateService.Prioritizer;
            this.PrioritizerRankings = this.gameStateService.PrioritizerRankings;
            this.GuesserRankings = this.gameStateService.GuesserRankings;

            Rankings = new ObservableCollection<Ranking>();
            ShowNext = false;
        }

        public void GetResult(int rank)
        {
            Ranking ranking = new Ranking() { Number = rank, Name = GuesserRankings[rank - 1] };

            if (GuesserRankings[rank - 1] == PrioritizerRankings[rank - 1])
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
        async Task Next()
        {
            // update game state service
            gameStateService.Score = Score;

            gameStateService.Round += 1;
            gameStateService.PrioritizerRankings.Clear();
            gameStateService.GuesserRankings.Clear();
            if (Round == TotalRounds)
            {
                await Shell.Current.GoToAsync(nameof(GameResultsPage));
            }
            //this.gameStateService.CurrentPlayer = this.gameStateService.Players[this.gameStateService.Players.IndexOf(this.Person) + 1];
            else
            {
                await Shell.Current.Navigation.PushAsync(new GetReadyPage(gameStateService));
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
