namespace Priorities.Views;
using Priorities.ViewModels;
using Priorities.Models;
using Priorities.Services;

public partial class RoundResultsPage : ContentPage
{
    private RoundResultsPageViewModel vm;

	public RoundResultsPage(IGameStateService gameStateService)
	{
		InitializeComponent();

        vm = new RoundResultsPageViewModel(gameStateService);
        BindingContext = vm;
	}

    void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
    {
		Shell.Current.FlyoutIsPresented = true;
    }

    protected override async void OnAppearing()
	{
        vm.ShowRankingsCommand.Execute(null);
	}
}