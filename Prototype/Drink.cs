using HealthKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    internal class Drink : Food
    {
        private string[] sizing = ["S", "M", "L"];
        private int size = 1;
    
        public Drink(string food, double price, string size):base(food,price) {
            for (int i = 0; i < sizing.Length; i++)
            { 
                if(size == sizing[i] && i!=1)
                {
                    this.size = i;
                }
            }
        }

        public override double getPrice()
        {
            double sizeCost = 0;
            if(this.size != 1)
            {
                if (this.size < 1)
                {
                    sizeCost = 1.00;
                }
                else {
                    sizeCost = -0.60;
                }
            }
            return ((price * quantity)+sizeCost);
        }

        public string getSize()
        {
            return sizing[this.size];
        }
    }
}
