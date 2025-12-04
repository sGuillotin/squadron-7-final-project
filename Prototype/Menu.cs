using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    internal class Menu
    {
        //menu page holder
        private Dictionary<string, Dictionary<string, Food>> menuPages;
        
        public Menu()
        {
            this.menuPages = new Dictionary<string, Dictionary<string, Food>>();
            this.menuPages["page"]["food"] = new Food("food", 1.00);
        }
    }
}
