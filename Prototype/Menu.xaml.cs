using System.Text.Json;

namespace MauiApp1;

public partial class Menu : ContentPage
{
    private readonly CartService _cart;
    LoginManager menuHelper = new LoginManager();
    private MenuData menuData = new MenuData();
    private Food oneFood;
    private Food twoFood;
    private Food threeFood;
    private Food fourFood;

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
                this.oneFood = menuData.getFood("Mains", "Margherita Pizza");
                one.Text = oneFood.Name;
                this.twoFood = menuData.getFood("Mains", "Spaghetti Carbonara");
                two.Text = twoFood.Name;
                this.threeFood = menuData.getFood("Mains", "Chicken Fettuccine Alfredo");
                three.Text = threeFood.Name;
                this.fourFood = menuData.getFood("Mains", "Penne Alla Vodka");
                four.Text = fourFood.Name;

                cone.Source = "pizza.png";
                ctwo.Source = "carbonara.png";
                cthree.Source = "alfredo.png";
                cfour.Source = "penne.png";
                break;

            case "Sides":
                this.oneFood = menuData.getFood("Sides", "Garlic Bread");
                one.Text = oneFood.Name;
                this.twoFood = menuData.getFood("Sides", "Caprese Salad");
                two.Text = twoFood.Name;
                this.threeFood = menuData.getFood("Sides", "Roasted Broccoli");
                three.Text = threeFood.Name;
                this.fourFood = menuData.getFood("Sides", "Focaccia Bread");
                four.Text = fourFood.Name;

                cone.Source = "bread.png";
                ctwo.Source = "caprese.png";
                cthree.Source = "broccoli.png";
                cfour.Source = "focaccia.png";
                break;

            case "Drinks":
                this.oneFood = menuData.getFood("Drinks", "Water");
                one.Text = oneFood.Name;
                this.twoFood = menuData.getFood("Drinks", "Espresso");
                two.Text = twoFood.Name;
                this.threeFood = menuData.getFood("Drinks", "Limonata");
                three.Text = threeFood.Name;
                this.fourFood = menuData.getFood("Drinks", "Chinotto");
                four.Text = fourFood.Name;

                cone.Source = "water.png";
                ctwo.Source = "espresso.png";
                cthree.Source = "limonata.png";
                cfour.Source = "chinotto.png";
                break;

            case "Desserts":
                this.oneFood = menuData.getFood("Desserts", "Tiramisu");
                one.Text = oneFood.Name;
                this.twoFood = menuData.getFood("Desserts", "Panna Cotta");
                two.Text = twoFood.Name;
                this.threeFood = menuData.getFood("Desserts", "Gelato");
                three.Text = threeFood.Name;
                this.fourFood = menuData.getFood("Desserts", "Cannoli");
                four.Text = fourFood.Name;

                cone.Source = "tiramisu.png";
                ctwo.Source = "panna.png";
                cthree.Source = "gelato.png";
                cfour.Source = "cannoli.png";
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
            _cart.AddFood(this.oneFood.Name,this.oneFood.Price);
        else if (sender == btwo)
            _cart.AddFood(this.twoFood.Name,this.twoFood.Price);
        else if (sender == bthree)
            _cart.AddFood(this.threeFood.Name,this.threeFood.Price);
        else if (sender == bfour)
            _cart.AddFood(this.fourFood.Name,this.fourFood.Price);
    }

}



