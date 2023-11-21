namespace Priorities.Views;
using Priorities.ViewModels;

public partial class GamePage : ContentPage
{
	public GamePage()
	{
		InitializeComponent();

        BindingContext = new GamePageViewModel();
    }

    void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
}