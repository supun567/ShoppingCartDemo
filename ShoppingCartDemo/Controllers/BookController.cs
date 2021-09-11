using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCartDemo.Models;
using ShoppingCartDemo.ViewModels;
using ShoppingCartDemo.Repositories;

namespace ShoppingCartDemo.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepo;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IAuthorRepository _authorRepo;

        public BookController(IBookRepository bookRepo, ICategoryRepository categoryRepo, IAuthorRepository authorRepo)
        {
            _bookRepo = bookRepo;
            _categoryRepo = categoryRepo;
            _authorRepo = authorRepo;
        }

        public ViewResult List()
        {
            return View(_bookRepo.AllBooks);
        }

        public ViewResult Discounts()
        {
            return View(_bookRepo.BooksWithDiscount);
        }

        public ViewResult ByCategory()
        {
            List<Book> Books = _bookRepo.AllBooks.ToList();

            BookListVM bookListVM = new()
            {
                Books = _bookRepo.AllBooks.Where(c=>c.Category == _categoryRepo.GetCategoryById(1).Description),
                SelectedCategoryDescription= _categoryRepo.GetCategoryById(2).Description
            };
                     
            return View(bookListVM);
        }
    }
}
