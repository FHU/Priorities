using Priorities.Services;
using Priorities.ViewModels;

namespace Priorities.Views
{
    public partial class HighScorePage : ContentPage
    {
        public HighScorePage(IGameStateService gameStateService)
        {
            InitializeComponent();

            BindingContext = new HighScorePageViewModel(gameStateService);
        }
        void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }
    }
}
