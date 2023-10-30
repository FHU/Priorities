using Priorities.ViewModels;

namespace Priorities.Views;

public partial class AchievementsPage : ContentPage
{
	public AchievementsPage()
	{
		InitializeComponent();

		BindingContext = new AchievementsPageViewModel();
	}
}
