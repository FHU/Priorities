using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;

namespace Priorities.ViewModels
{
    public partial class GamePageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string playerName;

        [ObservableProperty]
        public string playerImage;
        public GamePageViewModel() 
        {
            var playerOne = new Player
            {
                Name = "Gavin Boler",
                ImageName = "dotnet_bot.png"
            };

            playerName = playerOne.Name;
            playerImage = playerOne.ImageName;

        }
    }
}
