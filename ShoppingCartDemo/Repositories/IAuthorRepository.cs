using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCartDemo.Models;

namespace ShoppingCartDemo.Repositories
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> AllAuthors { get; }

        Author GetAuthorById(int id);
    }
}
