namespace Priorities.Views;
using Priorities.ViewModels;

public partial class AddPlayerPage : ContentPage
{
	public AddPlayerPage()
	{
        InitializeComponent();

		BindingContext = new AddPlayersPageViewModel();
    }

}