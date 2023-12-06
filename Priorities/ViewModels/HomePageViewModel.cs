using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Priorities.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;
using System.Collections.ObjectModel;
using Priorities.Services;

namespace Priorities.ViewModels
{
	public partial class HomePageViewModel
	{
		public HomePageViewModel()
		{
            [RelayCommand]
            async Task NavigateToPlayersPage()
            {
                await Shell.Current.GoToAsync(nameof(PlayersPage));
            }
        }
	}
}

