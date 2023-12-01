using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Priorities.Models;
using Priorities.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priorities.ViewModels
{
    public partial class AddPlayersPageViewModel : ObservableObject
    {

        private readonly IGameStateService gameStateService;

        /* name entry */
        [ObservableProperty]
        private string name;

        /* avatar image */
        [ObservableProperty]
        private string image;


        public AddPlayersPageViewModel(IGameStateService gameStateService)
        {
            this.gameStateService = gameStateService;

            //PropertyChanged += (s, e) =>
            //{
            //    if (e.PropertyName == nameof(Name))
            //    {
            //        string updateName = Name;
            //    }
            //    else if (e.PropertyName == nameof(Image))
            //    {
            //        string updateImage = Image;
            //    }
            //};

        }

        [RelayCommand]
        void AddPlayer() {

            gameStateService.Players.Add(
                new Player() { Name = this.Name, ImageName=Image });

            Shell.Current.GoToAsync("../");

        }

    }

}
