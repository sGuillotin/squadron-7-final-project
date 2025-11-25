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

        
    }
}
