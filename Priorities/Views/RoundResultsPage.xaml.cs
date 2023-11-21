namespace Priorities.Views;
using Priorities.ViewModels;

public partial class RoundResultsPage : ContentPage
{
	public RoundResultsPage()
	{
		InitializeComponent();
		BindingContext = new RoundResultsPageViewModel();
	}

    void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
    {
		Shell.Current.FlyoutIsPresented = true;
    }
}