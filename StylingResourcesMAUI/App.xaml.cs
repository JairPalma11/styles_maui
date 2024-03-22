using StylingResourcesMAUI.Navigations;
using StylingResourcesMAUI.Resources.Styles;

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

        //nos suscribimos para detectar cambios
        //en el tema actual
        //descomentar para probar
        RequestedThemeChanged += OnAppThemeChanged;
    }

    protected override void OnStart()
    {
        base.OnStart();
        //verificamos en que modo estamos para cargar el
        //thema correcto
        CheckAndChangeAppTheme(this.RequestedTheme);
    }

    private void CheckAndChangeAppTheme(AppTheme appTheme)
    {
        //obtenemos el merge dictionary
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;

        //lo limpiamos
        //y configuramos el tema sino es null
        if (mergedDictionaries == null)
        {
            return;
        }

        mergedDictionaries.Clear();

        //analizamos cual es el tema actual y lo agregamos
        //Importante: La bandera ConfigChanges.UiMode  debe estar en el Main Activity en Android.
        if (appTheme == AppTheme.Light ||
            appTheme == AppTheme.Unspecified)
        {
            mergedDictionaries.Add(new AppLightTheme());
        }
        else
        {
            mergedDictionaries.Add(new AppDarkTheme());
        }
    }

    /// <summary>
    /// Este metodo se ejecuta
    /// cuando el usuario cambia de tema oscuro a
    /// claro
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnAppThemeChanged(object? sender, AppThemeChangedEventArgs e)
    {
        CheckAndChangeAppTheme(e.RequestedTheme);
    }
}

