using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    //Food class - countains name string, price float, and int quantity
    internal class Food
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
        //getters for food and price - no setters since item data cannot be written by user
        public string getFood()
        {
            return food;
        }
        virtual public double getPrice()
        {
            return (price*quantity);
        }
        //for quantity, it'll be modified with add to cart - increment/decrement only for now
        public void addItem() { 
            this.quantity++;
        }
        public void removeItem() { 
            this.quantity--;
        }
        
    }
}
