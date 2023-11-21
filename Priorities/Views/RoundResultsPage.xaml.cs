namespace Priorities.Views;
using Priorities.ViewModels;
using Priorities.Models;

public partial class RoundResultsPage : ContentPage
{
    private RoundResultsPageViewModel vm = new RoundResultsPageViewModel();

	public RoundResultsPage()
	{
		InitializeComponent();
		BindingContext = vm;
	}

    void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
    {
		Shell.Current.FlyoutIsPresented = true;
    }
}