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
    
   

    private void AddItem(object sender, EventArgs e)
    {
        var food = (sender as Button)?.BindingContext as Food;
        if (food != null)
            _cart.AddFood(food.Name,food.Price);
    }

    private void RemoveItem(object sender, EventArgs e)
    {
        var food = (sender as Button)?.BindingContext as Food;
        if (food != null)
            _cart.SubtractFood(food);
    }

    private async void goToMenu(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Menu));
    }

    private async void goToConfirmation(object sender, EventArgs e)
    {
        //clears cart
        _cart.clearCart();
        await Shell.Current.GoToAsync(nameof(Confirmation));
    }


}

