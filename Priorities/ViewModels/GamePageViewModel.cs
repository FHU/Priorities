using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Priorities.Models;
using System.Collections.ObjectModel;
using Priorities.Services;
using Priorities.Views;

namespace Priorities.ViewModels
{
    public partial class GamePageViewModel : ObservableObject
    {

        private readonly IGameStateService gameStateService;

        [ObservableProperty]
        public bool prioritizing;

        [ObservableProperty]
        public bool guessing;

        [ObservableProperty]
        public string playerName;

        [ObservableProperty]
        public string playerImage;

        [ObservableProperty]
        public int round;

        [ObservableProperty]
        private int totalRounds;

        [ObservableProperty]
        public int score;

        [ObservableProperty]
        public string timer;

        public ObservableCollection<Priority> Priorities { get; set; }

        private Priority itemBeingDragged;

        public GamePageViewModel(IGameStateService gameStateService)
        {

            this.gameStateService = gameStateService;

            gameStateService.Phase = GamePhase.Prioritizing;

            gameStateService.Prioritizer = new Player()
            {
                Name = "K-Dawg",
                ImageName = "kenan.jpg"
            };

            gameStateService.Round = 1;
            gameStateService.TotalRounds = 10;

            gameStateService.Score = 0;


            var phase = gameStateService.Phase;


            /*Abbie*/

            playerName = gameStateService.Prioritizer.Name;
            playerImage = gameStateService.Prioritizer.ImageName;

            /*Priscilla*/

            Priorities = new ObservableCollection<Priority>();

            var items = gameStateService.GetRandomItems(5);
            foreach ( var item in items )
            {
                Priorities.Add(new Priority(item));
            }

            /*Gavin*/

            TotalRounds = gameStateService.TotalRounds;

            /*Priscilla*/
            timer = "0:43";
            score = gameStateService.Score;

            // for guessing / prioritizing mode
            if (phase.Equals(GamePhase.Prioritizing))
            {
                prioritizing = true;
                guessing = false;
            }
            else
            {
                prioritizing = false;
                guessing = true;
            }


        }


        [RelayCommand]
        async Task NavigateToNextPage()
        {
            var rankingList = new List<string>();
            foreach (var priority in Priorities)
            {
                rankingList.Add(priority.Thing);
            }
            if (gameStateService.Phase.Equals(GamePhase.Prioritizing))
            {
                gameStateService.PrioritizerRankings = rankingList;
                await Shell.Current.GoToAsync(nameof(GetReadyPage));

            }
            else
            {
                gameStateService.GuesserRankings = rankingList;
                await Shell.Current.GoToAsync(nameof(RoundResultsPage));
            }
        }

        // I got this off the internet
        // https://github.com/Alam-Ashraf/MAUIDragDropCollectionViewItemsDemo

        [RelayCommand]
        public void ItemDragged(Priority priority)
        {
            priority.IsBeingDragged = true;
            itemBeingDragged = priority;
        }
        [RelayCommand]
        public void ItemDragLeave(Priority priority)
        {
            priority.IsBeingDraggedOver = false;
        }
        [RelayCommand]
        public void ItemDraggedOver(Priority priority)
        {
            if (priority == itemBeingDragged)
            {
                priority.IsBeingDragged = false;
            }
            priority.IsBeingDraggedOver = priority != itemBeingDragged;
        }
        [RelayCommand]
        public void ItemDropped(Priority priority)
        {
            try
            {
                var itemToMove = itemBeingDragged;
                var itemToInsertBefore = priority;
                if (itemToMove == null || itemToInsertBefore == null || itemToMove == itemToInsertBefore)
                    return;
                int insertAtIndex = Priorities.IndexOf(itemToInsertBefore);
                if (insertAtIndex >= 0 && insertAtIndex < Priorities.Count)
                {
                    Priorities.Remove(itemToMove);
                    Priorities.Insert(insertAtIndex, itemToMove);
                    itemToMove.IsBeingDragged = false;
                    itemToInsertBefore.IsBeingDraggedOver = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(  ex );
            }
        }
    }
}