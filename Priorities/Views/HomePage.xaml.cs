using Priorities.ViewModels;
namespace Priorities.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();

    }

    async void Start_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(PlayersPage)}");
    }
    async void High_Scores_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(HighScorePage)}");
    }
    async void Achievements_Clicked(System.Object sender, System.EventArgs e)
    {
        //to do: change to achievements once in main
        await Shell.Current.GoToAsync($"{nameof(PlayersPage)}");
    }
    async void How_To_Play_Clicked(System.Object sender, System.EventArgs e)
    {
        //to do: change to how to play once in main
        await Shell.Current.GoToAsync($"{nameof(PlayersPage)}");
    }
}
