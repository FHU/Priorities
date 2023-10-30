using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Priorities.Views;
using Priorities.ViewModels;

namespace Priorities;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

			});

		builder.Services.AddTransient<RoundResultsPage>();
        builder.Services.AddTransient<RoundResultsPageViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

