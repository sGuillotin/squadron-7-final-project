using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace MauiApp1
{
    internal class MenuData
    {
        //menu page holder
        private Dictionary<string, Dictionary<string, Food>> menuPages;
        
        public MenuData()
        {
            this.menuPages = new Dictionary<string, Dictionary<string, Food>>();
            buildMenu();
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
        public void buildMenu()
        {
            //Menu build - pages
            this.addPage("Mains");
            this.addPage("Sides");
            this.addPage("Drinks");
            this.addPage("Desserts");
            //Menu build - food
            this.addFood("Mains", "Margherita Pizza", 19.00);
            this.addFood("Mains", "Spaghetti Carbonara", 22.00);
            this.addFood("Mains", "Chicken Fettuccine Alfredo", 24.00);
            this.addFood("Mains", "Penne Alla Vodka", 21.00);

            this.addFood("Sides", "Garlic Bread", 8.00);
            this.addFood("Sides", "Caprese Salad", 12.00);
            this.addFood("Sides", "Roasted Broccoli", 10.00);
            this.addFood("Sides", "Focaccia Bread", 9.00);

            this.addFood("Drinks", "Water", 2.00);
            this.addFood("Drinks", "Espresso", 5.00);
            this.addFood("Drinks", "Limonata", 6.00);
            this.addFood("Drinks", "Chinotto", 6.00);

            this.addFood("Desserts", "Tiramisu", 11.00);
            this.addFood("Desserts", "Panna Cotta", 10.00);
            this.addFood("Desserts", "Gelato", 8.00);
            this.addFood("Desserts", "Cannoli", 9.00);
        }
    }
}
