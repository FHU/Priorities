using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;
using Priorities.Services;
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


        public HighScorePageViewModel(IGameStateService gameStateService)
        {
            GameResults = new ObservableCollection<GameResult>();


            var gameResult = new GameResult()
            {
                Rank = 1,
                Score = 5000,
                Date = DateTime.Now,
                Team = new Team()
                {
                    Name = "EnglishMajors",
                    Players = new List<Player>
                {
                            new Player() { Name="Ashley", ImageName="kenan.jpeg" },
                            new Player() { Name="Hannah", ImageName="kenan.jpeg" },
                            new Player() { Name="Deb", ImageName="kenan.jpeg" },
                }
                },
                Achievements = new ObservableCollection<Achievement>
                {
                            new Achievement() { Title="Snail's Pace", Unlocked=true, DateUnlocked = DateTime.Now , Description = "Finish guessing with fewer than 5 seconds left in a round", Image = "snails.svg"},
                            new Achievement() { Title="Open Books", Unlocked=true, DateUnlocked = DateTime.Now, Description="Finish a game with a perfect score", Image = "book.svg" }, 
                            new Achievement() { Title="Perfectionist", Unlocked=true, DateUnlocked = DateTime.Now, Description="Get a perfect score in a round", Image = "trophy.svg" },
                            new Achievement() { Title="Rockstar", Unlocked=true, DateUnlocked = DateTime.Now, Description="Get 3 achievements in a game", Image="stars.svg" }
  },
            };
            GameResults.Add(gameResult);

            var gameResult1 = new GameResult()
            {
                Rank = 2,
                Score = 4095,
                Date = DateTime.Now,
                Team = new Team()
                {
                    Name = "Dream Team",
                    Players = new List<Player>
                {
                            new Player() { Name="kenan", ImageName="kenan.jpeg" },
                            new Player() { Name="kenan", ImageName="kenan.jpeg" },
                            new Player() { Name="kenan", ImageName="kenan.jpeg" },
                            new Player() { Name="kenan", ImageName="kenan.jpeg" }
                }
                },
                Achievements = new ObservableCollection<Achievement>
                {
                            new Achievement() { Title="Twinsies", Unlocked=true, DateUnlocked = DateTime.Now , Description = "Have 2 people with the same username in a game", Image="twins.svg"},
  },
            };
            GameResults.Add(gameResult1);

            var gameResult2 = new GameResult()
            {
                Rank = 3,
                Score = 3450,
                Date = DateTime.Now,
                Team = new Team()
                {
                    Name = "GhostCrew",
                    Players = new List<Player>
                    {
                        new Player() { Name = "Kanan", ImageName = "kenan.jpeg" },
                        new Player() { Name = "Hera", ImageName = "kenan.jpeg" },
                        new Player() { Name = "Chopper", ImageName = "kenan.jpeg" },
                        new Player() { Name = "Zeb", ImageName = "kenan.jpeg" },
                        new Player() { Name = "Ezra", ImageName = "kenan.jpeg" },
                    }
                },
                Achievements = new ObservableCollection<Achievement>
                {
                    new Achievement() {Title="Hooked In", Unlocked=true , DateUnlocked = DateTime.Now , Description="Play 10 games", Image="fishhook.svg"}
                }
  
            };
            GameResults.Add(gameResult2);


            var gameResult4 = new GameResult()
            {
                Rank = 4,
                Score = 2345,
                Date = DateTime.Now,
                Team = new Team()
                {
                    Name = "The Suits",
                    Players = new List<Player>
                {
                            new Player() { Name="TJ", ImageName="kenan.jpeg" },
                            new Player() { Name="President", ImageName="kenan.jpeg" },
                            new Player() { Name="Lacy", ImageName="kenan.jpeg" },
                }
                },
                Achievements = new ObservableCollection<Achievement>
                {
                            new Achievement() { Title="Great Start", Unlocked=true, DateUnlocked = DateTime.Now , Description = "Finish 1 game", Image="thumbsup.svg"},
  },
            };
            GameResults.Add(gameResult4);

            var gameResult5 = new GameResult()
            {
                Rank = 5,
                Score = 0,
                Date = DateTime.Now,
                Team = new Team()
                {
                    Name = "TeamRocket",
                    Players = new List<Player>
                {
                            new Player() { Name="Jesse", ImageName="kenan.jpg" },
                            new Player() { Name="James", ImageName="kenan.jpeg" },
                            new Player() { Name="Meowth", ImageName="kenan.jpeg" },
                }
                },
                Achievements = new ObservableCollection<Achievement>
                {
                            new Achievement() { Title="Ragnarok", Unlocked=true, DateUnlocked = DateTime.Now , Description = "End the game with 0 points", Image="bombs.svg"},
  },
            };
            GameResults.Add(gameResult5);

            

        }
       
        

    }
}
