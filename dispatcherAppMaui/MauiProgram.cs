using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using FreshMvvm.Maui.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace dispatcherAppMaui
{
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
			builder.Services.AddTransient<LoginPageModel>();
			builder.Services.AddTransient<LoginPageViewModel>();
			builder.Services.UseFreshMvvm();

			return builder.Build();
		}
	}
}