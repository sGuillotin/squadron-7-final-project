using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MauiApp1;

public class CartService
{
    public ObservableCollection<Food> Items { get; private set; } = new();

    public void AddFood(string foodName, double price = 0.00)
    {
        var existing = Items.FirstOrDefault(f => f.Name == foodName);

        if (existing != null)
        {
            existing.AddOne();
        }
        else
        {
            var food = new Food(foodName, price);
            food.AddOne();
            Items.Add(food);
        }
    }

    public void SubtractFood(Food food)
    {
        food.RemoveOne();

        if (food.Quantity == 0)
            Items.Remove(food);
    }
}





