namespace MauiApp1;

public partial class Orders : ContentPage
{
	public Orders()
	{
		InitializeComponent();
	}

    private async void goToMain(object sender, EventArgs e)
    {
        // Navigate to the MainPage, different path bc it is the inital page
        await Shell.Current.GoToAsync("//MainPage");
    }
}