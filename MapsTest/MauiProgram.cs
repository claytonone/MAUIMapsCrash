using Microsoft.Extensions.Logging;
using Plugin.Maui.BottomSheet.Hosting;

namespace MapsTest;

public static class MauiProgram
{

	public static MauiApp Service;

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiMaps()
			.UseBottomSheet()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		Service = builder.Build();

		return Service;
	}
}
