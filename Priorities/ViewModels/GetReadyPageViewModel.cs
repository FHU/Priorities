
using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;
using Priorities.Services;

namespace Priorities.ViewModels
{
    public partial class GetReadyPageViewModel : ObservableObject
    {
        private readonly IGameStateService gameStateService;

        [ObservableProperty]
        public int round;

        [ObservableProperty]
        private int totalRounds;

        [ObservableProperty]
        public string score;

        [ObservableProperty]
        Player currentPlayer;

        public GetReadyPageViewModel(IGameStateService gameStateService)
        {
            this.gameStateService = gameStateService;

            var players = gameStateService.Players;

            CurrentPlayer = players[0];
        }

        public GetReadyPageViewModel()
        {
        }
    }
}
