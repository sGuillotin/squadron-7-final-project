namespace MauiApp1;

public partial class Signup : ContentPage
{
	public Signup()
	{
		InitializeComponent();
	}
    private async void goToMain(object sender, EventArgs e)
    {
        // Navigate to the MainPage, different path bc it is the inital page
        await Shell.Current.GoToAsync("//MainPage");
    }

    private async void goToMenu(object sender, EventArgs e)
    {
        // Navigate to the Menu page using its route name
        await Shell.Current.GoToAsync(nameof(Menu));
    }
}