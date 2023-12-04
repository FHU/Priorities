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
        }

        [RelayCommand]
        async Task TakePhoto()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.CapturePhotoAsync();

                if (photo != null)
                {
                    // save the file into local storage
                    string localFilePath = Path.Combine(FileSystem.AppDataDirectory, photo.FileName);

                    using Stream sourceStream = await photo.OpenReadAsync();
                    using FileStream localFileStream = File.OpenWrite(localFilePath);

                    await sourceStream.CopyToAsync(localFileStream);

                    Image = localFilePath;
                }
            }
        }

        [RelayCommand]
        void AddPlayer()
        {

            gameStateService.Players.Add(
                new Player() { Name = this.Name, ImageName = Image });

            Shell.Current.GoToAsync("../");

        }

    }

}
