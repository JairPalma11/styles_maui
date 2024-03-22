namespace StylingResourcesMAUI.Pages;

public partial class DemoStaticResourcePage : ContentPage
{
	public DemoStaticResourcePage()
	{
		InitializeComponent();
	}

	//evento que se ejecuta cuando
	//presionamos el boton
    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		var key = "MyBackgroundColor";
		//agregamos el recurso a nivel
		//pagina sino existe
		if (!this.Resources.ContainsKey(key))
		{
			this.Resources.Add(key, Colors.BlueViolet);
		}
		else
		{
			//si existe el recurso cambiamos el color a otro
			this.Resources[key] = Colors.DarkCyan;
        }
    }
}
