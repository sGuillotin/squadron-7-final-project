namespace MauiApp1;

public partial class Cart : ContentPage
{
    public Cart()
    {
        InitializeComponent();
    }

    private async void goToMenu(object sender, EventArgs e)
    {
        // Navigate to the Menu page using its route name
        await Shell.Current.GoToAsync(nameof(Menu));
    }

    private async void goToConfirmation(object sender, EventArgs e)
    {
        // Navigate to the Confirmation page using its route name
        await Shell.Current.GoToAsync(nameof(Confirmation));
    }

}