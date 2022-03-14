using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiBlazorDialogSample.Data;

namespace MauiBlazorDialogSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddBlazorWebView();
		builder.Services.AddSingleton<WeatherForecastService>();

		builder.Services.AddSingleton<IDialogService, DialogService>();

		return builder.Build();
	}
}
