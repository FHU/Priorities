using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;

namespace Priorities.ViewModels
{
    public partial class RoundResultsPageViewModel : ObservableObject
    {
        public RoundResultsPageViewModel()
        {
            Person = new Player() { Name = "John", ImageName = "dotnet_bot.svg" };
            Round = 1;
            Score = 20;
        }

        [ObservableProperty]
        private int round;

        [ObservableProperty]
        private int score;

        [ObservableProperty]
        private Player person;





    }

    
}
