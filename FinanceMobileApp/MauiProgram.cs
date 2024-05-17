using Microsoft.Maui.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceMobileApp;

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
		builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001") });
		return builder.Build();
	}
}
