namespace MauiApp1;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private async void goToCart(object sender, EventArgs e)
    {
        // Navigate to the Cart page using its route name
        await Shell.Current.GoToAsync(nameof(Cart));
    }

    private async void goToLogin(object sender, EventArgs e)
    {
        // Navigate to the Login page using its route name
        await Shell.Current.GoToAsync(nameof(Login));
    }
}