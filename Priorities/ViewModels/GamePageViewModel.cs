using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Priorities.Models;
using System.Collections.ObjectModel;
using Priorities.Services;

namespace Priorities.ViewModels
{
    public partial class GamePageViewModel : ObservableObject
    {

        private readonly IGameStateService gameStateService;

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

            gameStateService.CurrentPlayer = new Player()
            {
                Name = "K-Dawg",
                ImageName = "kenan.jpg"
            };

            gameStateService.Round = 1;
            gameStateService.TotalRounds = 10;

            gameStateService.Score = 0;


            /*Abbie*/

            playerName = gameStateService.CurrentPlayer.Name;
            playerImage = gameStateService.CurrentPlayer.ImageName;

            /*Priscilla*/
            Priorities = new ObservableCollection<Priority>();

            Priorities.Add(new Priority("Turtles"));
            Priorities.Add(new Priority("Evan Kahan"));
            Priorities.Add(new Priority("Microwave"));
            Priorities.Add(new Priority("Musicals"));
            Priorities.Add(new Priority("Calculus"));

            /*Gavin*/
            Round = gameStateService.Round;
            TotalRounds = gameStateService.TotalRounds;

            /*Priscilla*/
            timer = "0:43";
            score = gameStateService.Score;



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