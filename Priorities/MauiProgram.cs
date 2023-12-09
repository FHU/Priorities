using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Priorities.Views;
using Priorities.ViewModels;
using Priorities.Models;
using Priorities.Services;

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
				fonts.AddFont("Coiny-Regular.ttf", "CoinyRegular");
				fonts.AddFont("ConcertOne-Regular.ttf", "ConcertOneRegular");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

			});

		

		builder.Services.AddSingleton<IGameStateService, GameStateService>();

		builder.Services.AddTransient<AddPlayerPageViewModel>();
        builder.Services.AddTransient<AddPlayerPage>();

        builder.Services.AddTransient<PlayersPageViewModel>();
        builder.Services.AddTransient<PlayersPage>();

        builder.Services.AddTransient<RoundResultsPage>();
        builder.Services.AddTransient<RoundResultsPageViewModel>();

        builder.Services.AddTransient<GamePage>();
        builder.Services.AddTransient<GamePageViewModel>();

        builder.Services.AddTransient<GetReadyPage>();
        builder.Services.AddTransient<GetReadyPageViewModel>();

        builder.Services.AddTransient<HighScorePage>();
        builder.Services.AddTransient<HighScorePageViewModel>();

        builder.Services.AddTransient<GameResultsPage>();
        //builder.Services.AddTransient<GameResultsPageViewModel>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

