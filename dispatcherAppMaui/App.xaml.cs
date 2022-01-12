using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace dispatcherAppMaui
{
	public partial class App : Application
	{
		//public const string BaseURL = "https://e-amanahkwt.com/customerappback/";
		//public const string BaseURL = "https://e-amanahkwt.com/maintenanceback-staging/";
		public const string BaseURL = "http://37.34.189.202:8030/maintenancepro-dev/";

		public static string UserManagmentBaseUrl = BaseURL;

		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new LoginPage());
		}
	}
}
