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
        }
        //Food class - countains name string, and price float
        public class Food {
             private string food;
             private float price;
            public Food(string food, float price) {
                this.food = food;
                this.price = price;

            }
            //getters for food and price - no setters since item data cannot be written by user
            public string getFood() {
                return food;
            }
            public float getPrice() {
                return price;
            }
        }
    }
}
