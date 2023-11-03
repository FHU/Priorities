using Priorities.ViewModels;

namespace Priorities.Views;

public partial class GameResultsPage : ContentPage
{
	public GameResultsPage()
	{
		InitializeComponent();

		BindingContext = new GameResultsPageViewModel();
	}
}
