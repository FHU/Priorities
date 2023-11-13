using Priorities.Services;
using Priorities.ViewModels;

namespace Priorities.Views;

public partial class PlayersPage : ContentPage
{
	private PlayersPageViewModel viewModel;

	public PlayersPage(IGameStateService gameStateService)
	{
		InitializeComponent();

		viewModel = new PlayersPageViewModel(gameStateService);
		BindingContext = viewModel;
		viewModel.LoadData();
	}

	void Button_Clicked(System.Object sender, System.EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(AddPlayerPage));
	}

	protected override void OnAppearing()
	{
		viewModel.LoadData();
	}

}
