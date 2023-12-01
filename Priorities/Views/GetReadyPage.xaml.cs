using Priorities.ViewModels;

namespace Priorities.Views;

public partial class GetReadyPage : ContentPage
{
	public GetReadyPage()
	{
        InitializeComponent();

		this.BindingContext =  new GetReadyPageViewModel();

    }

    void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
}
