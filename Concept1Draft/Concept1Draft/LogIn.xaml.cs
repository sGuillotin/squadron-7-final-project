namespace Concept1Draft
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSinClicked(object sender, EventArgs e)
        {
            Alert.Text = "Account not found";

            nothin();
        }

        private void OnUpClicked(object sender, EventArgs e)
        {
            Alert.Text = "Unable to sign up right now";

            nothin();
        }

        public void nothin()
        {
            if (string.IsNullOrWhiteSpace(User.Text) || string.IsNullOrWhiteSpace(Pass.Text))
            {
                Alert.Text = "You must fill in both username and password.";
                return;
            }

        }

    }
}
