namespace MauiApp1;

public partial class Menu : ContentPage
{
    private readonly CartService _cart;

    public Menu(CartService cart)
    {
        InitializeComponent();
        _cart = cart;

        // Default selection
        Foods.SelectedIndex = 0;
    }

    private async void goToCart(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Cart));
    }

    private async void goToLogin(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Login));
    }

    private async void OnFoodSelected(object sender, EventArgs e)
    {
        string selected = Foods.SelectedItem.ToString();

        switch (selected)
        {
            case "Mains":
                one.Text = "Cheeseburger";
                two.Text = "Tacos (3)";
                three.Text = "Chicken tenders (3)";
                four.Text = "Salad";
                break;

            case "Sides":
                one.Text = "Fries";
                two.Text = "Mozzarella sticks";
                three.Text = "Onion rings";
                four.Text = "Chips";
                break;

            case "Drinks":
                one.Text = "Water bottle";
                two.Text = "Cola";
                three.Text = "Diet cola";
                four.Text = "Mtn Dew: Baja Blast";
                break;

            case "Desserts":
                one.Text = "Churro";
                two.Text = "Cookie";
                three.Text = "Brownie";
                four.Text = "Donut";
                break;
        }

        // Make all add buttons visible
        bone.IsVisible = true;
        btwo.IsVisible = true;
        bthree.IsVisible = true;
        bfour.IsVisible = true;
    }

    private void AddOrder(object sender, EventArgs e)
    {
        if (sender == bone)
            _cart.AddItem(one.Text);
        else if (sender == btwo)
            _cart.AddItem(two.Text);
        else if (sender == bthree)
            _cart.AddItem(three.Text);
        else if (sender == bfour)
            _cart.AddItem(four.Text);
    }
}



