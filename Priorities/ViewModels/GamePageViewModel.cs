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

        /*Timer (Luke Noles)*/

        public GamePageViewModel()
        {
            /*Abbie*/
            var playerOne = new Player
            {
                Name = "Gavin Boler",
                ImageName = "dotnet_bot.png"
            };

            playerName = playerOne.Name;
            playerImage = playerOne.ImageName;

            /*Priscilla*/
            Priorities.Add(new Priority("Turtles"));
            Priorities.Add(new Priority("Evan Kahan"));
            Priorities.Add(new Priority("Microwave"));
            Priorities.Add(new Priority("Musicals"));
            Priorities.Add(new Priority("Calculus"));

            /*Gavin*/

            /*Luke*/

        }
    }
}
