using NavigationPatternsMAUI.Navigations;

namespace StylingResourcesMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MyTabbedPage();
	}
}

