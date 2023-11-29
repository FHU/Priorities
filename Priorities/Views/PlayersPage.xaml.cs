namespace Priorities.Views;
using Priorities.ViewModels;

public partial class PlayersPage : ContentPage
{
    public PlayersPage()
    {
        InitializeComponent();
        BindingContext = new PlayersPageViewModel();
    }

    void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }

}