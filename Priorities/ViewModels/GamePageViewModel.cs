using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;
using System.Collections.ObjectModel;

namespace Priorities.ViewModels
{
    public partial class GamePageViewModel : ObservableObject
    {
        /*Player Properties (Abbie Vance)*/
        [ObservableProperty]
        public string playerName;

        [ObservableProperty]
        public string playerImage;

        /*Priority Card Properties (Priscilla Harris)*/
        public ObservableCollection<Priority> Priorities { get; set; }

        /*Round and Score Properties (Gavin Boler)*/
        [ObservableProperty]
        public string roundNumber;

        /*Timer (Priscilla Harris)*/
        [ObservableProperty]
        public string score;

        [ObservableProperty]
        public string timer;
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
            roundNumber = "1/10";

            /*Priscilla*/
            timer = "0:43";
            score = "0";


        }
    }
}