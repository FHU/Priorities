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
        public ObservableCollection<Achievement> achievements { get; private set; }

        public HighScorePageViewModel()
        {
            GameResults = new ObservableCollection<GameResult>();

            GameResult = new GameResult()
            {
                Score = 4999,
                Date = DateTime.Now,
                Team = new Team() { Name="Skellingtons"},
                Achievements = achievements
            };
            GameResults.Add(GameResult);
            

        }
        [ObservableProperty]
        private GameResult gameResult;
    }
}
