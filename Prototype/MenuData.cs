using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    internal class MenuData
    {
        //menu page holder
        private Dictionary<string, Dictionary<string, Food>> menuPages;
        
        public MenuData()
        {
            this.menuPages = new Dictionary<string, Dictionary<string, Food>>();
            this.menuPages["page"]["food"] = new Food("food", 1.00);
        }
    }
}
