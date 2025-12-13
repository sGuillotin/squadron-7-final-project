namespace MauiApp1;

public partial class Menu : ContentPage
{
    private readonly CartService _cart;
    LoginManager menuHelper = new LoginManager();

    public Menu(CartService cart)
    {
        InitializeComponent();
        _cart = cart;

        // Default selection
        Foods.SelectedIndex = 0;

        // Sebastien added this
        // add $"Sign out of {usr.Text}" to sign out button
        signout.Text = $"Sign out of {menuHelper.currentUser}"; // TODO debug
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
                one.Text = "Margherita Pizza";
                two.Text = "Spaghetti Carbonara";
                three.Text = "Chicken Fettuccine Alfredo";
                four.Text = "Penne Alla Vodka";

                cone.Source = "pizza.png";
                ctwo.Source = "carbonara.png";
                cthree.Source = "alfredo.png";
                cfour.Source = "penne.png";
                break;

            case "Sides":
                one.Text = "Garlic Bread";
                two.Text = "Caprese Salad";
                three.Text = "Roasted Broccoli";
                four.Text = "Focaccia Bread";
                break;

            case "Drinks":
                one.Text = "Water";
                two.Text = "Espresso";
                three.Text = "Limonata";
                four.Text = "Chinotto";
                break;

            case "Desserts":
                one.Text = "Tiramisu";
                two.Text = "Panna Cotta";
                three.Text = "Gelato";
                four.Text = "Canoli";
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
            _cart.AddFood(one.Text);
        else if (sender == btwo)
            _cart.AddFood(two.Text);
        else if (sender == bthree)
            _cart.AddFood(three.Text);
        else if (sender == bfour)
            _cart.AddFood(four.Text);
    }

}



