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

namespace Priorities.ViewModels
{
    public partial class RoundResultsPageViewModel : ObservableObject
    {
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

        public RoundResultsPageViewModel()
        {
            Rankings = new ObservableCollection<Ranking>();
            Person = new Player() { Name = "K-Dawg", ImageName = "kenan.jpeg" };

            string i1 = "Giraffe";
            string i2 = "Chocolate";
            string i3 = "Fruit";
            string i4 = "Sleep";
            string i5 = "Casey";

            PlayerRanking = new List<string> { i1, i2, i3, i4, i5 };
            GroupRanking = new List<string> { i1, i2, i4, i3, i5 };
            Round = 1;
            Score = 0;
            TotalRounds = 10;
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
            // change page and add round and score as variables
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
