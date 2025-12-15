using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp1
{
    public class Food : INotifyPropertyChanged
    {
        protected string food;
        protected double price;
        protected int quantity;

        public Food(string food, double price)
        {
            this.food = food;
            this.price = price;
            this.quantity = 1;
        }

        public Food(string food)
        {
            this.food = food;
            this.price = 0;
            this.quantity = 1;
        }

        public string Name => food;

        public int Quantity
        {
            get => quantity;
            protected set
            {
                if (quantity != value)
                {
                    quantity = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Price));
                }
            }
        }

        public double Price => getPrice();

        public virtual double getPrice()
        {
            return price * quantity;
        }

        public void AddOne()
        {
            Quantity++;
        }

        public void RemoveOne()
        {
            if (Quantity > 0)
                Quantity--;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
