namespace NavigationPatternsMAUI.Pages;

public partial class ContactPage : ContentPage
{
	public ContactPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Console.WriteLine("Se ejecuta OnAppearing cuanto esta visible la pagina");
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        Console.WriteLine("Se ejecuta OnDisappearing cuanto NO esta visible la pagina");
    }
}
