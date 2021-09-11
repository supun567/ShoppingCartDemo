using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCartDemo.Models;

namespace ShoppingCartDemo.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> AllBooks { get; }
        IEnumerable<Book> BooksWithDiscount { get; }

        Book GetBookById(int id);

        Book GetBookByIsbn(string isbn);

        Book GetBookByCategory(string categoryDescription);
    }
}
