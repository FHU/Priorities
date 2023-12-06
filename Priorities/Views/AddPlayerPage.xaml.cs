namespace Priorities.Views;

using Priorities.Services;
using Priorities.ViewModels;

public partial class AddPlayerPage : ContentPage
{
	public AddPlayerPage(IGameStateService gameStateService)
	{
        InitializeComponent();

        charLimitLabel.IsVisible = true;

        BindingContext = new AddPlayersPageViewModel( gameStateService);
    }

    void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)	
    {	
        Entry entry = (Entry)sender;	

        int currentLength = entry.Text.Length;	
        int maxLength = entry.MaxLength;	

        // Update the character count label 	
        charLimitLabel.Text = $"{currentLength}/{maxLength}";	
    }


}