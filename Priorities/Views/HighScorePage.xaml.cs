using Priorities.ViewModels;

namespace Priorities.Views
{
    public partial class HighScorePage : ContentPage
    {
        public HighScorePage()
        {
            InitializeComponent();

            BindingContext = new HighScorePageViewModel();
        }
        void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }
    }
}
