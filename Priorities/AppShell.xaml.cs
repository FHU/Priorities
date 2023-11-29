namespace Priorities;
using Views;
public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();


		Routing.RegisterRoute(nameof(AddPlayerPage), typeof(AddPlayerPage));
        Routing.RegisterRoute(nameof(Views.GamePage), typeof(Views.GamePage));
        Routing.RegisterRoute(nameof(Views.GameResultsPage), typeof(Views.GameResultsPage));
        Routing.RegisterRoute(nameof(Views.GameStatusBar), typeof(Views.GameStatusBar));
        Routing.RegisterRoute(nameof(Views.GetReadyPage), typeof(Views.GetReadyPage));
        Routing.RegisterRoute(nameof(Views.HighScorePage), typeof(Views.HighScorePage));
        Routing.RegisterRoute(nameof(Views.HomePage), typeof(Views.HomePage));
        Routing.RegisterRoute(nameof(Views.PlayersPage), typeof(Views.PlayersPage));
        Routing.RegisterRoute(nameof(Views.RoundResultsPage), typeof(Views.RoundResultsPage));
    }
}

