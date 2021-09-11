using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCartDemo.Models;

namespace ShoppingCartDemo.ViewModels
{
    public class BookListVM
    {
        public IEnumerable<Book> Books { get; set; }

        public string SelectedCategoryDescription { get; set; }
    }
}
