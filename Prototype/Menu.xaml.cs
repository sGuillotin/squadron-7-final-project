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

    private async void OnFoodSelected(object sender, EventArgs e) 
    {
        string selected = Foods.SelectedItem.ToString();

        switch (selected)
        {
            case "Mains":
                one.Text = "Cheeseurger";
                two.Text = "Tacos (3)";
                three.Text = "Chicken tenders (3)";
                four.Text = "Salad";

                bone.IsVisible = true;
                btwo.IsVisible = true;
                bthree.IsVisible = true;
                bfour.IsVisible = true;
                break;

            case "Sides":
                one.Text = "Fries";
                two.Text = "Mozzarella sticks";
                three.Text = "Onion rings";
                four.Text = "Chips";

                bone.IsVisible = true;
                btwo.IsVisible = true;
                bthree.IsVisible = true;
                bfour.IsVisible = true;
                break;

            case "Drinks":
                one.Text = "Water bottle";
                two.Text = "Cola";
                three.Text = "Diet cola";
                four.Text = "Mtn Dew: Baja Blast";

                bone.IsVisible = true;
                btwo.IsVisible = true;
                bthree.IsVisible = true;
                bfour.IsVisible = true;
                break;

            case "Desserts":
                one.Text = "Churro";
                two.Text = "Cookie";
                three.Text = "Brownie";
                four.Text = "Donut";

                bone.IsVisible = true;
                btwo.IsVisible = true;
                bthree.IsVisible = true;
                bfour.IsVisible = true;
                break;
        }
    }

    private async void AddOrder(object sender, EventArgs e)
    {
        await DisplayAlert("unable to add item", "Items cannot be added to your order at this time", "Ok");
    }
}

