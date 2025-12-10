//using CloudKit;
//FRONT-END: not sure what's causing the issue with the above line,  but commenting it out removes the build error with no new deformities to sign-up. - Sam

namespace MauiApp1;

public partial class Signup : ContentPage
{
    readonly LoginManager signuper = new LoginManager();
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
    // Ensure username is not already taken - handled by LoginManager
    // Call .register
    // Print a confirmation message on the UI

    // CODE
    private async void goToMenu(object sender, EventArgs e)
    {
        //ensure both entries are filled
        //if either is blank:
        if (string.IsNullOrWhiteSpace(usr.Text) || string.IsNullOrWhiteSpace(pas.Text))
        {
            Error.Text = "Username and password MUST be filled in to sign up";
        }
        else
        {
            //register new user
            try
            {
                LoginManager.RegisterNewUser(usr.Text, pas.Text, signuper.login); //TODO rewrite to work when login is private/read only?

                // Navigate to the Menu page using its route name if textbox is filled
                await Shell.Current.GoToAsync(nameof(Menu));
            }
            //if RegisterNewUser throws exception (bc username already taken), catch it and display error
            catch (InvalidOperationException) //type of error object to catch
            {
                Error.Text = "Username already taken.";
            }
        }
    }
}