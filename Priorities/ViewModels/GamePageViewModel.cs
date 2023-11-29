using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

        private Priority itemBeingDragged;

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