using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;
using CommunityToolkit.Mvvm.Input;

namespace Priorities.ViewModels
{
    public partial class RoundResultsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private int round;

        [ObservableProperty]
        private int score;

        [ObservableProperty]
        private Player person;

        private List<string> PlayerRanking { get; set; }

        private List<string> GroupRanking { get; set; }

        public ObservableCollection<Ranking> rankings { get; set; }

        public RoundResultsPageViewModel()
        {
            //rankings = new ObservableCollection<Ranking>();
            //Person = new Player() { Name = "John", ImageName = "dotnet_bot.svg" };
            //var rank1 = "Giraffe";
            //var rank2 = "Chocolate";
            //var rank3 = "Fruit";
            //var rank4 = "Sleep";
            //var rank5 = "Casey";
            //PlayerRanking = new List<string> { rank1, rank2, rank3, rank4, rank5 };

            //var grank1 = "Giraffe";
            //var grank2 = "Chocolate";
            //var grank3 = "Sleep";
            //var grank4 = "Fruit";
            //var grank5 = "Casey";
            //GroupRanking = new List<string> { grank1, grank2, grank3, grank4, grank5 };
            //Score = 0;
            //Compare(PlayerRanking, GroupRanking);
            //Round = 1;

            rankings = new ObservableCollection<Ranking>();
            Person = new Player() { Name = "John", ImageName = "dotnet_bot.svg" };

            string i1 = "Giraffe";
            string i2 = "Chocolate";
            string i3 = "Fruit";
            string i4 = "Sleep";
            string i5 = "Casey";

            PlayerRanking = new List<string> { i1, i2, i3, i4, i5 };
            GroupRanking = new List<string> { i1, i2, i4, i3, i5 };
            Round = 1;
            Score = 0;

            for (int i = 5; i > 0; i--)
            {
                Thread.Sleep(1000); // doesn't work yet
                Ranking result = GetResult(i);
                rankings.Insert(0, result);
                Score += result.Points;
            }
        }

        void Compare(List<string> pRank, List<string> gRank)
        {
            for (int i = 0; i < pRank.Count; i++)
            {
                if (pRank[i] == gRank[i])
                {
                    //rankings.Add(new Ranking { Name = pRank[i], Number = i + 1, Sign = "+", Points = 25 - (5 * i), ImagePath = "green_check.svg" });
                    Score = Score + (25 - (5 * i));
                }
                else
                {
                    //rankings.Add(new Ranking { Name = pRank[i], Number = i + 1, Sign = "-", Points = 25 - (5 * i), ImagePath = "red_x.svg" });
                    Score = Score - (25 - (5 * i));
                }
            }
        }

        Ranking GetResult(int rank)
        {
            Ranking ranking = new Ranking() { Number = rank, Name = GroupRanking[rank - 1] };

            if (GroupRanking[rank - 1] == PlayerRanking[rank - 1])
            {
                ranking.Points = 25 - (5 * (rank - 1));
                ranking.Color = Color.FromArgb("#74C1DD");
            }
            else
            {
                ranking.Points = -1 * (25 - (5 * (rank - 1)));
                ranking.Color = Color.FromArgb("#EC6664");
            }

            return ranking;
        }

        [RelayCommand]
        void Next()
        {
            Round++;
            // change page and add round and score as variables
        }

    }


}
