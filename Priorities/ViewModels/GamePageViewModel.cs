﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Priorities.Models;
using System.Collections.ObjectModel;
using Priorities.Services;
using Priorities.Views;
using System.Collections.Generic;

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
            round = gameStateService.Round;


            var phase = gameStateService.Phase;


            /*Abbie*/

            playerName = gameStateService.Prioritizer.Name;
            playerImage = gameStateService.Prioritizer.ImageName;

            /*Priscilla*/

            Priorities = new ObservableCollection<Priority>();

            if (phase.Equals(GamePhase.Prioritizing))
            {
                var items = gameStateService.GetRandomItems();
                foreach (var item in items)
                {
                    Priorities.Add(new Priority(item));
                }
            }
            else
            {
                Random random = new Random();
                // I found this line on the internet, but I deleted the link (sorry)
                List<string> shuffledPriorities = gameStateService.PrioritizerRankings.OrderBy(i => random.Next()).ToList();
                foreach (var priority in shuffledPriorities)
                {
                    Priorities.Add(new Priority(priority));
                }

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
                await Shell.Current.Navigation.PushAsync(new GetReadyPage(gameStateService));

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