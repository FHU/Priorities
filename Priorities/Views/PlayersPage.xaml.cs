namespace Priorities.Views;
using Priorities.ViewModels;

public partial class PlayersPage : ContentPage
{
    public PlayersPage()
    {
        InitializeComponent();
        BindingContext = new PlayersPageViewModel();
    }

}