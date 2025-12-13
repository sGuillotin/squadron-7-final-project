using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class Food
    {
        // Made fields protected so subclasses still work
        protected string food;
        protected double price;
        protected int quantity;

        public Food(string food, double price)
        {
            this.food = food;
            this.price = price;
            this.quantity = 1;
        }

        // Properties for XAML binding
        public string Name => food;
        public int Quantity => quantity;

        // Must be virtual (SizedFood depends on this)
        public virtual double getPrice()
        {
            return price * quantity;
        }

        //
        public void AddOne()
        {
            quantity++;
        }

        public void RemoveOne()
        {
            if (quantity > 0)
                quantity--;
        }

        public Food(string food)
        {
            this.food = food;
            this.price = 0;
            this.quantity = 1;
        }

    }
}






