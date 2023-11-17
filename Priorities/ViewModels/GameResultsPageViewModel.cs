using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        
        
        public ObservableCollection<Achievement> Achievements { get; set; }

        public GameResultsPageViewModel() 
        {
            Score = 4999;
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
        }
        
    }
}
