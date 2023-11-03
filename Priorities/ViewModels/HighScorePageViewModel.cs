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
    public class HighScorePageViewModel : ObservableObject
    {
        public ObservableCollection<GameResult> GameResults { get; set; }
        public HighScorePageViewModel()
        {
            GameResults = new ObservableCollection<GameResult>();

        }
    }
}
