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
}