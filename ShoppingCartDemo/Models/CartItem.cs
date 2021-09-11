using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartDemo.Models
{
    public class CartItem
    {
        public Book PurchasedBook { get; set; }
        public int Quantity { get; set; }
    }
}
