using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Converters;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Priorities.Models;
using Priorities.Services;
using Priorities.Views;

namespace Priorities.ViewModels
{
    public partial class GetReadyPageViewModel : ObservableObject
    {
        private IGameStateService gameStateService;

        [ObservableProperty]
        public int round;

        [ObservableProperty]
        private int totalRounds;

        [ObservableProperty]
        public int score;

        [ObservableProperty]
        Player currentPlayer;

        [ObservableProperty]
        Player currentPrioritizer;

        [ObservableProperty]
        Player currentGuesser;

        [ObservableProperty]
        public int guesserIndex;

        [ObservableProperty]
        public int prioritizerIndex;

        private List<string> PrioritizerRankings { get; set; }

        private string currentRound { get; set; }

        public GetReadyPageViewModel(IGameStateService gameStateService)
        {
            this.gameStateService = gameStateService;


            totalRounds = gameStateService.TotalRounds;
            round = gameStateService.Round;
            score = gameStateService.Score;

            PrioritizerRankings = gameStateService.PrioritizerRankings;

            var Players = gameStateService.Players;

            PrioritizerIndex = gameStateService.PrioritizerIndex;
            GuesserIndex = gameStateService.GuesserIndex;



            if (PrioritizerRankings == null || PrioritizerRankings.Count == 0)
            {
                gameStateService.Phase = GamePhase.Prioritizing;
               

                //Random random = new Random();
                //int randomIndex = random.Next(Players.Count);


                if (gameStateService.PrioritizerIndex == Players.Count-1)
                {
                    PrioritizerIndex = 0;
                    gameStateService.PrioritizerIndex = prioritizerIndex;
                    gameStateService.Prioritizer = Players[PrioritizerIndex];
                    CurrentPrioritizer = gameStateService.Prioritizer;
                    CurrentPlayer = gameStateService.Prioritizer;
                }

                else
                {
                    PrioritizerIndex++;
                    gameStateService.PrioritizerIndex = prioritizerIndex;
                    gameStateService.Prioritizer = Players[PrioritizerIndex];
                    CurrentPrioritizer = gameStateService.Prioritizer;
                    CurrentPlayer = gameStateService.Prioritizer;
                }
            }
            else
            {
                gameStateService.Phase = GamePhase.Guessing;
                

                //gameStateService.Phase = GamePhase.Guessing;
                //Random random = new Random();
                //int randomIndex = random.Next(Players.Count);
                //gameStateService.Guesser = Players[randomIndex];
                //while (gameStateService.Guesser.Equals(gameStateService.Prioritizer))
                //{
                //    randomIndex = random.Next(Players.Count);
                //    gameStateService.Guesser = Players[randomIndex];
                //}

                if (gameStateService.GuesserIndex == Players.Count-1)
                {
                    GuesserIndex = 0;
                    gameStateService.Guesser = Players[GuesserIndex];
                    gameStateService.GuesserIndex = GuesserIndex;
                    CurrentGuesser = gameStateService.Guesser;
                    CurrentPlayer = gameStateService.Guesser;
                }
                else
                {
                    GuesserIndex++;
                    gameStateService.Guesser = Players[GuesserIndex];
                    gameStateService.GuesserIndex = GuesserIndex;
                    CurrentGuesser = gameStateService.Guesser;
                    CurrentPlayer = gameStateService.Guesser;
                }

                

                
            }


        }
        [RelayCommand]
        async Task NavigateToGamePage()
        {
            await Shell.Current.GoToAsync(nameof(GamePage));
        }
    }
}