namespace MauiApp1;

public partial class Login : ContentPage
{
    // create an instance of our login manager (file to be: LoginManager.cs)
    // one for both signup and login? I guess this instance wouldn't have to be "persistent" or constantly "alive"...
    // TODO code here

	public Login()
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
        // further handle input from the user here-
        // validate input using login manager
        
        // if username matches a password in the database (read from dictionary using stream)
        // let them in
        // if not a match
        // let them know

        // TODO code here

        //ensure both entries are filled
        if (string.IsNullOrWhiteSpace(usr.Text) || string.IsNullOrWhiteSpace(pas.Text))
        {
            Error.Text = "Username and password MUST be filled in to sign in";
        }
        else { Error.Text = ""; }

        if (Error.Text == "")
        {         
            // Navigate to the Menu page using its route name if there is no error
            await Shell.Current.GoToAsync(nameof(Menu));
        }
    }

    private async void goToSignup(object sender, EventArgs e)
    {
        // Navigate to the Signup page using its route name
        await Shell.Current.GoToAsync(nameof(Signup));
    }

}