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
        public RoundResultsPageViewModel()
        {
            rankings = new ObservableCollection<Ranking>();
            Person = new Player() { Name = "John", ImageName = "dotnet_bot.svg" };
            var rank1 = "Giraffe";
            var rank2 = "Chocolate" ;
            var rank3 = "Fruit" ;
            var rank4 = "Sleep" ;
            var rank5 = "Casey" ;
            PlayerRanking = new List<String> { rank1, rank2, rank3, rank4, rank5 };

            var grank1 = "Giraffe" ;
            var grank2 = "Chocolate" ;
            var grank3 = "Sleep" ;
            var grank4 = "Fruit" ;
            var grank5 = "Casey" ;
            GroupRanking = new List<String> { grank1, grank2, grank3, grank4, grank5 };
            Compare(PlayerRanking, GroupRanking);
            Round = 1;
            Score = 20;
        }

        [ObservableProperty]
        private int round;

        [ObservableProperty]
        private int score;

        [ObservableProperty]
        private Player person;

        private List<String> PlayerRanking { get; set; }

        private List<String> GroupRanking { get; set; }

        public ObservableCollection<Ranking> rankings { get; set; }

         void Compare(List<String> pRank, List<String> gRank)
        {
            for (int i = 0; i < pRank.Count; i++) {
                if (pRank[i] == gRank[i])
                {
                    rankings.Add(new Ranking { Name = pRank[i], Number = i + 1, Sign = "+", Points = 25 - (5*i), ImagePath = "green_check.svg" });
                }
                else
                {
                    rankings.Add(new Ranking { Name = pRank[i], Number = i + 1, Sign = "-", Points = 25 - (5*i), ImagePath = "red_x.svg" });
                }
            }
        }

        [RelayCommand]
        void Next()
        {
          
            Round++;
            // change page and add round and score as variables
        }

    }

    
}
