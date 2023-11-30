using Priorities.ViewModels;

namespace Priorities.Views;

public partial class GameResultsPage : ContentPage
{
	public GameResultsPage()
	{
		InitializeComponent();

		BindingContext = new GameResultsPageViewModel();
	}

    void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
}
