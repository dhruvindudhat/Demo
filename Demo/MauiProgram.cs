using Microsoft.AspNetCore.Components.WebView.Maui;
using Demo.Data;
using Blazored.Modal;

namespace Demo;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        builder.Services.AddBlazoredModal();
        builder.Services.AddScoped<ModelDialogService>();
        builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}

