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
    }
}
