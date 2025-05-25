using Plugin.Maui.BottomSheet.Navigation;

namespace MapsTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		var s = MauiProgram.Service.Services.GetService<IBottomSheetNavigationService>();
	
		return new Window(new NavigationPage(new MainPage(s)));
	}
}