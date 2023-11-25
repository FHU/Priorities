using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Priorities.Views;
using Priorities.ViewModels;
using Priorities.Models;
using Camera.MAUI;

namespace Priorities;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCameraView()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Coiny-Regular.ttf", "CoinyRegular");
				fonts.AddFont("ConcertOne-Regular.ttf", "ConcertOneRegular");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

			});

		builder.Services.AddTransient<RoundResultsPage>();
        builder.Services.AddTransient<RoundResultsPageViewModel>();
		builder.Services.AddTransient<Ranking>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

