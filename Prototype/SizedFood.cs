using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    internal class SizedFood: Food
    {
        protected string[] sizing = ["S", "M", "L"];
        protected int size = 1;
        protected double bigCost;
        protected double smallCost;
        public SizedFood(string food, double price, string size):base(food, price)
        {
            for (int i = 0; i < sizing.Length; i++)
            {
                if (size == sizing[i] && i != 1)
                {
                    this.size = i;
                }
            }
            this.bigCost = 1.50;
            this.smallCost = -1.00;
        }

        public override double getPrice()
        {
            if (this.size != 1)
            {
                if (this.size < 1)
                {
                    return ((this.price + bigCost) * quantity);
                }
                else
                {
                    return ((this.price + smallCost) * quantity);
                }
            }
            return (this.price*quantity);
        }

        public string getSize()
        {
            return sizing[this.size];
        }
    }
}
