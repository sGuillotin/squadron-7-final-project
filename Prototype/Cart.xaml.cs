namespace MauiApp1;

public partial class Cart : ContentPage
{
    private readonly CartService _cart;

    public Cart(CartService cart)
    {
        InitializeComponent();
        _cart = cart;

        CartList.ItemsSource = _cart.Items;
    }

    private async void goToMenu(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Menu));
    }

    private async void goToConfirmation(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Confirmation));
    }
}

