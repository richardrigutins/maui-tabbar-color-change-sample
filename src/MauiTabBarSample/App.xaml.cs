namespace MauiTabBarSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		// Register the routes for all the pages in the app.
		Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
		Routing.RegisterRoute(nameof(MauiTabBarSample.MainPage), typeof(MainPage));
		Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
	}
}
