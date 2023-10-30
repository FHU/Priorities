using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;

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
        [ObservableProperty]
        public string thingOne;

        [ObservableProperty]
        public string thingTwo;

        [ObservableProperty]
        public string thingThree;

        [ObservableProperty]
        public string thingFour;

        [ObservableProperty]
        public string thingFive;

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
            var priorityOne = new Priority
            {
                PriorityOne = "Turtles"
            };

            var priorityTwo = new Priority
            {
                PriorityTwo = "Evan Kahan"
            };

            var priorityThree = new Priority
            {
                PriorityThree = "Microwaves"
            };

            var priorityFour = new Priority
            {
                PriorityFour = "Musicals"
            };

            var priorityFive = new Priority
            {
                PriorityFive = "Calculus"
            };

            thingOne = priorityOne.PriorityOne;
            thingTwo = priorityTwo.PriorityTwo;
            thingThree = priorityThree.PriorityThree;
            thingFour = priorityFour.PriorityFour;
            thingFive = priorityFive.PriorityFive;

            /*Gavin*/

            /*Luke*/

        }
    }
}
