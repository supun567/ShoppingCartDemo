using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCartDemo.Models;

namespace ShoppingCartDemo.Repositories
{
    public interface IMockShoppingCartRepository
    {
        List<CartItem> GetItemsInCart { get; }
        bool RemoveItem(CartItem item);

        bool AddItem(CartItem item);



    }
}
