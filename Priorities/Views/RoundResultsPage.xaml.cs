namespace Priorities.Views;
using Priorities.ViewModels;

public partial class RoundResultsPage : ContentPage
{
	public RoundResultsPage()
	{
		InitializeComponent();
		BindingContext = new RoundResultsPageViewModel();
	}
}