using NavigationPatternsMAUI.Navigations;
using StylingResourcesMAUI.Pages;

namespace StylingResourcesMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		//para probar recursos dinamicos y estaticos
		MainPage = new DemoStaticResourcePage();
	}
}

