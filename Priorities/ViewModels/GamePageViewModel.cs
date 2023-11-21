using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;
using System.Collections.ObjectModel;

namespace Priorities.ViewModels
{
    public partial class GamePageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string playerName;

        [ObservableProperty]
        public string playerImage;

        [ObservableProperty]
        public int round;

        [ObservableProperty]
        private int totalRounds;

        [ObservableProperty]
        public string score;

        [ObservableProperty]
        public string timer;

        public ObservableCollection<Priority> Priorities { get; set; }

        public GamePageViewModel()
        {
            /*Abbie*/
            var playerOne = new Player
            {
                Name = "K-Dawg",
                ImageName = "kenan.jpeg"
            };

            playerName = playerOne.Name;
            playerImage = playerOne.ImageName;

            /*Priscilla*/
            Priorities = new ObservableCollection<Priority>();

            Priorities.Add(new Priority("Turtles"));
            Priorities.Add(new Priority("Evan Kahan"));
            Priorities.Add(new Priority("Microwave"));
            Priorities.Add(new Priority("Musicals"));
            Priorities.Add(new Priority("Calculus"));

            /*Gavin*/
            Round = 1;
            TotalRounds = 10;

            /*Priscilla*/
            timer = "0:43";
            score = "0";


        }
    }
}