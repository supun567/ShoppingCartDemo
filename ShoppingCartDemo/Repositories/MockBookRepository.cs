using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCartDemo.Models;
using ShoppingCartDemo.Repositories;


namespace ShoppingCartDemo.Repositories
{
    public class MockBookRepository : IBookRepository
    {
        //private readonly IBookRepository _BookRepository;

        
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAuthorRepository _authorRepository;
        public MockBookRepository(ICategoryRepository categoryRepository, IAuthorRepository authorRepository)
        {
            _categoryRepository = categoryRepository;
            _authorRepository = authorRepository;
        }

        //public MockBookRepository(IBookRepository repo)
        //{
        //    _BookRepository = repo;
        //}

        public IEnumerable<Book> AllBooks => new List<Book> { 
            new Book
            {
                Id=101,
                Isbn="978-1-56619-909-4",
                Title="The Island",
                ReleaseYear=2019,
                Category= _categoryRepository.GetCategoryById(1).Description,
                Price=150,
                ImageUrl="101.jpg",
                Author=(string)_authorRepository.GetAuthorById(101).FirstName + " "+ (string)_authorRepository.GetAuthorById(101).LastName
            },
            new Book
            {
                Id=102,
                Isbn="978-1-56689-200-2",
                Title="Twilight",
                ReleaseYear=2020,
                Category= _categoryRepository.GetCategoryById(2).Description,
                Price=225,
                ImageUrl="102.jpg",
                Author=(string)_authorRepository.GetAuthorById(102).FirstName + " "+ (string)_authorRepository.GetAuthorById(102).LastName
            },
            new Book
            {
                Id=103,
                Isbn="100-1-58569-200-2",
                Title="The Haunted House",
                ReleaseYear=2020,
                Category= _categoryRepository.GetCategoryById(1).Description,
                Price=225,
                ImageUrl="103.jpg",
                Author=  (string)_authorRepository.GetAuthorById(103).FirstName + " "+ (string)_authorRepository.GetAuthorById(103).LastName
            }
        };

        public IEnumerable<Book> BooksWithDiscount => new List<Book> {
            new Book
            {
                Id=103,
                Isbn="100-1-58569-200-2",
                Title="The Haunted House",
                ReleaseYear=2020,
                Category= _categoryRepository.GetCategoryById(1).Description,
                Price=225,
                ImageUrl="103.jpg",
                Author=  (string)_authorRepository.GetAuthorById(103).FirstName + " "+ (string)_authorRepository.GetAuthorById(103).LastName },
            new Book
            {
                Id=102,
                Isbn="978-1-56689-200-2",
                Title="Twilight",
                ReleaseYear=2020,
                Category= _categoryRepository.GetCategoryById(2).Description,
                Price=225,
                ImageUrl="102.jpg",
                Author=(string)_authorRepository.GetAuthorById(102).FirstName + " "+ (string)_authorRepository.GetAuthorById(102).LastName
           }
        };

        public Book GetBookByCategory(string categoryDescription)
        {
            return AllBooks.FirstOrDefault(c => c.Category == categoryDescription);
        }

        public Book GetBookById(int id)
        {
            return AllBooks.FirstOrDefault(c=>c.Id ==id);
        }

        public Book GetBookByIsbn(string isbn)
        {
            return AllBooks.FirstOrDefault(c => c.Isbn == isbn);
        }
    }
}
