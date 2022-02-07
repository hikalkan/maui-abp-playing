using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiDemoUi.Data;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using System.Reflection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

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
			})
			.Host
			.ConfigureAppConfiguration((app, config) =>
			{
				var assembly = typeof(App).GetTypeInfo().Assembly;
				config.AddJsonFile(new EmbeddedFileProvider(assembly), "appsettings.json", optional: false, false);
			});

		builder.Host.UseAutofac();

		builder.Services.AddApplication<MauiDemoUiModule>(options =>
        {
			options.Services.ReplaceConfiguration(builder.Configuration);
		});

		var app = builder.Build();

		app.Services.GetRequiredService<IAbpApplicationWithExternalServiceProvider>().Initialize(app.Services);

		return app;
	}
}
