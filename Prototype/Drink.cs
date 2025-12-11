using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    internal class Drink : SizedFood
    {
        
        private bool hasIce = false;
    
        public Drink(string food, double price, string size, bool hasIce):base(food,price,size) {
            this.hasIce = hasIce;
            this.bigCost = 1.00;
            this.smallCost = -0.60;
        }
        public bool getIce()
        {
            return hasIce;
        }
    }
}
