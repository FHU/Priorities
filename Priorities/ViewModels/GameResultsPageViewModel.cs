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
            achievement.Description = "Finish one game";

            Achievements.Add(achievement);
        }

    }
}
