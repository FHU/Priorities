namespace Priorities.Views;

using Camera.MAUI;
using Priorities.ViewModels;

public partial class AddPlayerPage : ContentPage
{
	public AddPlayerPage()
	{
        InitializeComponent();

		BindingContext = new AddPlayersPageViewModel();
    }

    void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }

    void cameraView_CamerasLoaded(System.Object sender, System.EventArgs e)
    {

        if( cameraView.Cameras.Count > 0)
        {
            cameraView.Camera = cameraView.Cameras.First();

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                await cameraView.StopCameraAsync();
                var result = await cameraView.StartCameraAsync();
            });
        }
        else
        {
            Console.WriteLine("No CAMERAS");
        }

       
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        avatarPic.Source = cameraView.GetSnapShot(Camera.MAUI.ImageFormat.JPEG);
    }
}