using MauiApp_Test1.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiApp_Test1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

        //Register MainPage & MainViewModel as DI Services 
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

        //Register DetailPage & DetailViewModel as DI Services 
		// NOTE since we create a new detail-page everytime we nevigate to it - hence we use Transient 
		// Also, we need to register new Detail-page to the Routing system - @ dotnet MAUI shell @ AppShell
        builder.Services.AddTransient<DetailPage>();
        builder.Services.AddTransient<DetailViewModel>();




        return builder.Build();
	}
}
