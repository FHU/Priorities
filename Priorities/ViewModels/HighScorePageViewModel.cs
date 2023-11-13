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


        public HighScorePageViewModel()
        {
            GameResults = new ObservableCollection<GameResult>();


            var gameResult = new GameResult()
            {
                Rank = 1,
                Score = 4999,
                Date = DateTime.Now,
                Team = new Team()
                {
                    Name = "Skellingtons",
                    Players = new List<Player>
                {
                            new Player() { Name="kenan", ImageName="kenan.jpeg" },
                            new Player() { Name="kenan2", ImageName="kenan.jpeg" },
                            new Player() { Name="kenan3", ImageName="kenan.jpeg" },
                            new Player() { Name="kenan4", ImageName="kenan.jpeg" }
                }
                },
                Achievements = new ObservableCollection<Achievement>
                {
                            new Achievement() { Title="Title 1", Unlocked=true, DateUnlocked = DateTime.Now , Description = "blah"},
                            new Achievement() { Title="Title 2", Unlocked=true, DateUnlocked = DateTime.Now, Description="no" }, 
                            new Achievement() { Title="Title 3", Unlocked=true, DateUnlocked = DateTime.Now, Description="double no" },
                            new Achievement() { Title="Title 4", Unlocked=true, DateUnlocked = DateTime.Now, Description="triple no" }
  },
            };
            GameResults.Add(gameResult);

            var gameResult1 = new GameResult()
            {
                Rank = 2,
                Score = 2998,
                Date = DateTime.Now,
                Team = new Team()
                {
                    Name = "Penguins",
                    Players = new List<Player>
                {
                            new Player() { Name="kelly", ImageName="kenan.jpeg" },
                            new Player() { Name="kelly2", ImageName="kenan.jpeg" },
                            new Player() { Name="kelly3", ImageName="kenan.jpeg" },
                            new Player() { Name="kelly4", ImageName="kenan.jpeg" }
                }
                },
                Achievements = new ObservableCollection<Achievement>
                {
                            new Achievement() { Title="Not-Title 1", Unlocked=true, DateUnlocked = DateTime.Now , Description = "blah"},
  },
            };
            GameResults.Add(gameResult1);

            var gameResult2 = new GameResult()
            {
                Rank = 3,
                Score = 1,
                Date = DateTime.Now,
                Team = new Team()
                {
                    Name = "testing",
                    Players = new List<Player>
                    {
                        new Player() { Name = "kelly", ImageName = "kenan.jpeg" },
                    }
                },
  
            };
            GameResults.Add(gameResult2);


            var gameResult4 = new GameResult()
            {
                Rank = 4,
                Score = 2345,
                Date = DateTime.Now,
                Team = new Team()
                {
                    Name = "Chemistry",
                    Players = new List<Player>
                {
                            new Player() { Name="ella", ImageName="kenan.jpeg" },
                            new Player() { Name="ella1", ImageName="kenan.jpeg" },
                            new Player() { Name="ella2", ImageName="kenan.jpeg" },
                            new Player() { Name="ella3", ImageName="kenan.jpeg" }
                }
                },
                Achievements = new ObservableCollection<Achievement>
                {
                            new Achievement() { Title="Not-Title 1", Unlocked=true, DateUnlocked = DateTime.Now , Description = "blah"},
                            new Achievement() { Title="Caffeine", Unlocked=true, DateUnlocked = DateTime.Now , Description = "blah"},
                            new Achievement() { Title="Snail's Pace", Unlocked=true, DateUnlocked = DateTime.Now , Description = "blah"},
  },
            };
            GameResults.Add(gameResult4);

            var gameResult5 = new GameResult()
            {
                Rank = 5,
                Score = 2345,
                Date = DateTime.Now,
                Team = new Team()
                {
                    Name = "English Major",
                    Players = new List<Player>
                {
                            new Player() { Name="Hannah", ImageName="kenan.jpeg" },
                }
                },
                Achievements = new ObservableCollection<Achievement>
                {
                            new Achievement() { Title="Jane Austen", Unlocked=true, DateUnlocked = DateTime.Now , Description = "blah"},
                            new Achievement() { Title="Single Eagle", Unlocked=true, DateUnlocked = DateTime.Now , Description = "blah"},
  },
            };
            GameResults.Add(gameResult5);

            

        }
       
        

    }
}
