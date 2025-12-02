using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MauiApp1;

public class CartService
{
    public ObservableCollection<CartItem> Items { get; private set; } = new();

    public void AddItem(string itemName)
    {
        var existing = Items.FirstOrDefault(i => i.Name == itemName);

        if (existing != null)
        {
            existing.Quantity++;
        }
        else
        {
            Items.Add(new CartItem { Name = itemName, Quantity = 1 });
        }
    }

    public void Clear()
    {
        Items.Clear();
    }
}


