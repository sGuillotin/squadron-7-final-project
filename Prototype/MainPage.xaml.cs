namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void goToLogin(object sender, EventArgs e)
        {
            // Navigate to the Login page using its route name
            await Shell.Current.GoToAsync(nameof(Login));
        }

        private async void goToSignup(object sender, EventArgs e)
        {
            // Navigate to the Signup page using its route name
            await Shell.Current.GoToAsync(nameof(Signup));
        }

        //Food class - countains name string, and price float
        public class Food {
             private string food;
             private float price;
            public Food(string food, float price) {
                this.food = food;
                this.price = price;

    }
}
