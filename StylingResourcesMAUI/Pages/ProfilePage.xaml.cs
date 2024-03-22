namespace StylingResourcesMAUI.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Navigation.PushAsync(new ContactPage());
    }
}
