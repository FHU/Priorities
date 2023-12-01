namespace Priorities.Views;

using Priorities.Services;
using Priorities.ViewModels;

public partial class AddPlayerPage : ContentPage
{
	public AddPlayerPage(IGameStateService gameStateService)
	{
        InitializeComponent();

		BindingContext = new AddPlayersPageViewModel( gameStateService);
    }

}