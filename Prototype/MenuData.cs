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
        //adds page to menu
        public void addPage(string page)
        {
            this.menuPages[page] = new Dictionary<string, Food>();
        }
        //adds Food item to menu page
        public void addFood(string page, string food, double price)
        {
            this.menuPages[page][food] = new Food(food, price);
        }
        //gets menu page
        public Dictionary<string,Food> getPage(string page) {
            return this.menuPages[page];
        }
        //gets Food item
        public Food getFood(string page, string food) {
            return this.menuPages[page][food];
        }
    }
}
