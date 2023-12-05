using System;
using Priorities.Models;

namespace Priorities.Services
{
	public class GameStateService : IGameStateService
	{
		public GameStateService()
		{

			Players = new();
			ItemList = new List<string>();

        }

		public List<Player> Players { get; set; }

		public int Score { get; set; }

		public int Round { get; set; }
		public int TotalRounds { get; set;}

		public TimeSpan TimeElapsed { get; set; }

		public List<string> PrioritizerRankings { get; set; }
		public List<string> GuesserRankings { get; set; }

		public Player Prioritizer { get; set; }

		public Player Guesser { get; set; }

		public GamePhase Phase { get; set; }


        private List<string> ItemList { get; set; }
	


        public List<string> GetRandomItems(int number)
        {
            List<string> randomItems = new List<string>();
            readFromFile();

            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                int randomIndex = random.Next(ItemList.Count);
                randomItems.Add(ItemList[randomIndex]);
                ItemList.Remove(ItemList[randomIndex]);
            }

            return randomItems;
        }

        private async void readFromFile()
        {
            string line;

            using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("words.txt");
            using StreamReader reader = new StreamReader(fileStream);
            
            while((line  = reader.ReadLine()) != null) {
                ItemList.Add(line);
            }

            

        }



    }
}