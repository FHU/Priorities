using Priorities.ViewModels;
using Priorities.Services;
namespace Priorities.Views;

public partial class GetReadyPage : ContentPage
{
    private GetReadyPageViewModel viewModel;
    public GetReadyPage(IGameStateService gameStateService)
    {
        InitializeComponent();

        viewModel = new GetReadyPageViewModel(gameStateService);
        BindingContext = viewModel;
    }

    void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
}
