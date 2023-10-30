namespace Priorities.Views;
using Priorities.ViewModels;

public partial class GamePage : ContentPage
{
	public GamePage()
	{
		InitializeComponent();

        BindingContext = new GamePageViewModel();
    }
}