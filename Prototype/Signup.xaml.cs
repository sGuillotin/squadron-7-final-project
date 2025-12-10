namespace MauiApp1;

public partial class Signup : ContentPage
{
    LoginManager loginer = new LoginManager();
    public Signup()
	{
		InitializeComponent();
	}
    private async void goToMain(object sender, EventArgs e)
    {
        // Navigate to the MainPage, different path bc it is the inital page
        await Shell.Current.GoToAsync("//MainPage");
    }

    // Connect code on this page to same as login page - use LoginManager
    // Check for empty fields
    // Ensure username is not already taken
    // Call .register in available
    // Print a confirmation message on the UI
    
    // CODE
    private async void goToMenu(object sender, EventArgs e)
    {
        //ensure both entries are filled
        //if either is blank:
        if(string.IsNullOrWhiteSpace(usr.Text) || string.IsNullOrWhiteSpace(pas.Text))
        {
            Error.Text = "Username and password MUST be filled in to sign up";
        }
        else {
            //register new user
            loginer.RegisterNewUser(usr.Text, pas.Text, loginer); //TODO debuug this
        
            // Navigate to the Menu page using its route name if textbox is filled
            await Shell.Current.GoToAsync(nameof(Menu));
        }
    }
}