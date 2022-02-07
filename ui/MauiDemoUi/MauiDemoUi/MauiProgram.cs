using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiDemoUi.Data;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

namespace MauiDemoUi;

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


		builder.Services.AddApplication<MauiDemoUiModule>();

		var app = builder.Build();

		app.Services.GetRequiredService<IAbpApplicationWithExternalServiceProvider>().Initialize(app.Services);

		return app;
	}
}
