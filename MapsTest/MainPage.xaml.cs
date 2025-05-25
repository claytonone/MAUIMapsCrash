using Plugin.Maui.BottomSheet.Navigation;

namespace MapsTest;

public partial class MainPage : ContentPage
{
	private readonly IBottomSheetNavigationService _bottomSheetNavigationService;

	public MainPage(IBottomSheetNavigationService bottomSheetNavigationService)
	{
		InitializeComponent();
		
		_bottomSheetNavigationService = bottomSheetNavigationService;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		_bottomSheetNavigationService.NavigateToAsync(new BSView());
	}
}
