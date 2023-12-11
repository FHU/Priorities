namespace Priorities.Views;
using Priorities.ViewModels;
using Priorities.Services;

public partial class GamePage : ContentPage
{
    private GamePageViewModel viewModel;
    public GamePage(IGameStateService gameStateService)
	{
		InitializeComponent();

        viewModel = new GamePageViewModel(gameStateService);
        BindingContext = viewModel;
    }

    void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }

}
