using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCartDemo.Models;

namespace ShoppingCartDemo.ViewModels
{
    public class ShoppingCartVM
    {
        public IEnumerable<CartItem> CartItems { get; set; }

        public double Discounts { get; } = 0.05;
    }
}
