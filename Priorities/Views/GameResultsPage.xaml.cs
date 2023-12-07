using Priorities.ViewModels;
using Priorities.Services;
namespace Priorities.Views;

public partial class GameResultsPage : ContentPage
{
    private GameResultsPageViewModel viewModel;
    public GameResultsPage(IGameStateService gameStateService)
	{
		InitializeComponent();

        viewModel = new GameResultsPageViewModel(gameStateService);
        BindingContext = viewModel;
    }

    void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
}
