using Priorities.ViewModels;
using Priorities.Views;

namespace Priorities;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();


        MainPage = new AppShell();

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#endif
        });
    }

}

