namespace MauiApp1;

public partial class Login : ContentPage
{
    // this is c# for the frontend functionality - no backend code here yet
    // will be integrated later like Cart to Menu

    // create an instance of our login manager (of LoginManager.cs)
    // one for both signup and login? I guess this instance wouldn't have to be "persistent" or constantly "alive"...
    LoginManager loginer = new LoginManager();

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
        // SUMMARY
        // further handle input from the user here-
        // validate input 

        // if username matches a password in the database (read from dictionary using stream)
        // let them in
        // if not a match
        // let them know

        // CODE
        // Ensure both entries are filled
        // if not filled, display error message
        if (string.IsNullOrWhiteSpace(usr.Text) || string.IsNullOrWhiteSpace(pas.Text))
        {
            Error.Text = "Username and password MUST be filled in to sign in";
        }
        // validate login (using method of login manager object)
        else if (loginer.ValidateLogin(usr.Text, pas.Text))
        {
            // Error.Text = $"Welcome, {usr.Text}"; // how display in a diff color for success message?
            Console.WriteLine($"Login successful; Welcome, {usr.Text}");
            System.Diagnostics.Debug.WriteLine($"Login successful; Welcome, {usr.Text}"); // what's this do? "- debug console output?" thanks IntelliJ
            // put them through to the Menu page if they valid
            // Navigate to the Menu page using its route name if there is no error
            await Shell.Current.GoToAsync(nameof(Menu));
        }
        else
        {
            // on invalid login, display error message
            Error.Text = "Invalid username or password. Please try again.";
        }
    }

    private async void goToSignup(object sender, EventArgs e)
    {
        // Navigate to the Signup page using its route name
        await Shell.Current.GoToAsync(nameof(Signup));
    }

}