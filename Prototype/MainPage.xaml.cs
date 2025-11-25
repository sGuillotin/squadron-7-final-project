namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
            /*SIDE NOTE IDEA: 
            For the issues of multi-page access, maybe 2 files?
            One for the cart (List<Food> [I’m going to add more to Food so it can have a quantity value for add to cart])
            and one for the menu (2D List<Food> for the menu tabs) that get converted back and forth between JSON - Thoughts?
            */
        }

    }
}
