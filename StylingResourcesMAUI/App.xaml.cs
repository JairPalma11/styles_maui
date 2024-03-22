using NavigationPatternsMAUI.Navigations;
using StylingResourcesMAUI.Pages;

namespace StylingResourcesMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		//para probar recursos dinamicos y estaticos
		//descomenta aqui
		//MainPage = new DemoStaticResourcePage();

		//para ver estilos y temas
		//descomenta aqui
		MainPage = new MyTabbedPage();
    }
}

