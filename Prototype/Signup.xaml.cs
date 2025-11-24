namespace MauiApp1;

public partial class Signup : ContentPage
{
	public Signup()
	{
		InitializeComponent();
	}
    private async void goToMain(object sender, EventArgs e)
    {
        // Navigate to the MainPage, different path bc it is the inital page
        await Shell.Current.GoToAsync("//MainPage");
    }

    private async void goToMenu(object sender, EventArgs e)
    {
        //ensure both entries are filled
        if(string.IsNullOrWhiteSpace(usr.Text) || string.IsNullOrWhiteSpace(pas.Text))
        {
            Error.Text = "Username and password MUST be filled in to sign up";
        }
        else { Error.Text = ""; }

        if (Error.Text == "")
        {
            // Navigate to the Menu page using its route name if textbox is filled
            await Shell.Current.GoToAsync(nameof(Menu));
        }
    }
}