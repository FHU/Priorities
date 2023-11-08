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
    public partial class HighScorePageViewModel : ObservableObject
    {
        public ObservableCollection<GameResult> GameResults { get; set; }

        public ObservableCollection<Achievement> Achievements { get; set; }

        public HighScorePageViewModel()
        {
            GameResults = new ObservableCollection<GameResult>();


            GameResult = new GameResult()
            {
                Score = 4999,
                Date = DateTime.Now,
                Team = new Team() { Name = "Skellingtons" },
                Achievements = new ObservableCollection<Achievement>
                {
                            new Achievement() { Title="Title 1", Unlocked=true, DateUnlocked = DateTime.Now , Description = "blah"},
                            new Achievement() { Title="Title 2", Unlocked=true, DateUnlocked = DateTime.Now, Description="no" }, 
                            new Achievement() { Title="Title 2", Unlocked=true, DateUnlocked = DateTime.Now, Description="double no" }
  },
            };
            GameResults.Add(GameResult);

        }
        [ObservableProperty]
        private GameResult gameResult;

        [ObservableProperty]
        private Achievement gameAchievement;
    }
}
