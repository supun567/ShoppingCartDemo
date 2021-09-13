using ShoppingCartDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartDemo.Repositories
{
    public class MockShoppingCartRepository : IShoppingCartRepository
    {
        private readonly List<CartItem> _newCart;

        public MockShoppingCartRepository()
        {
            if (_newCart == null)
            {
                _newCart = new List<CartItem>();
            }
        }

        public List<CartItem> GetItemsInCart => _newCart;

        public bool AddItem(CartItem item)
        {
            _newCart.Add(item);
            return true;
        }

        public bool RemoveItem(CartItem item)
        {
            if (!_newCart.Any()) //No items in Cart
            {
                return false;
            }
            else
            {
                _newCart.Remove(item);
                return true;
            }
        }
    }
}
