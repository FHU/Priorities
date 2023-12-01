namespace Priorities.Views;

using Camera.MAUI;
using Priorities.Services;
using Priorities.ViewModels;

public partial class AddPlayerPage : ContentPage
{
	public AddPlayerPage(IGameStateService gameStateService)
	{
        InitializeComponent();

		BindingContext = new AddPlayersPageViewModel( gameStateService);
    }

    void HamburgerMenuButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }

    void cameraView_CamerasLoaded(System.Object sender, System.EventArgs e)
    {

        if (cameraView.Cameras.Count > 0)
        {
            // Use this for real cameras
            // cameraView.Camera = cameraView.Cameras[1];

            // Use this for simulators
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
        cameraView.StopCameraAsync();
        avatarPic.IsVisible = true;
        cameraView.IsVisible = false;
        smile.IsVisible = false;
        retake.IsVisible = true;

    }

    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        cameraView.StartCameraAsync();
        avatarPic.IsVisible = false;
        cameraView.IsVisible = true;
        smile.IsVisible = true;
        retake.IsVisible = false;
    }
}