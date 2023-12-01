namespace Priorities;
using Views;
public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();


		Routing.RegisterRoute(nameof(AddPlayerPage), typeof(AddPlayerPage));
        Routing.RegisterRoute(nameof(GamePage), typeof(GamePage));
        Routing.RegisterRoute(nameof(GameResultsPage), typeof(GameResultsPage));
        Routing.RegisterRoute(nameof(GetReadyPage), typeof(GetReadyPage));
        Routing.RegisterRoute(nameof(HighScorePage), typeof(HighScorePage));
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(PlayersPage), typeof(PlayersPage));
        Routing.RegisterRoute(nameof(RoundResultsPage), typeof(RoundResultsPage));
    }
}

