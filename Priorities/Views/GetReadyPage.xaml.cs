using Priorities.ViewModels;

namespace Priorities.Views;

public partial class GetReadyPage : ContentPage
{
	public GetReadyPage()
	{
		InitializeComponent();

		this.BindingContext =  new GetReadyPageViewModel();
	}
}
