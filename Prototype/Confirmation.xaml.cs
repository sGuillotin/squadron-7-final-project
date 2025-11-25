namespace MauiApp1;

public partial class Confirmation : ContentPage
{
	public Confirmation()
	{
		InitializeComponent();
	}

    private async void goToMenu(object sender, EventArgs e)
    {
        // Navigate to the Menu page using its route name
        await Shell.Current.GoToAsync(nameof(Menu));
    }

    private async void goToOrders(object sender, EventArgs e)
    {
        // Navigate to the Orders page using its route name
        await Shell.Current.GoToAsync(nameof(Orders));
    }
}