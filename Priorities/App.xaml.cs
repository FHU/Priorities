using Priorities.Views;

namespace Priorities;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new PlayersPage();
	}
}

