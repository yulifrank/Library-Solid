using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.servies.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepositor;
        public BookService(IBookRepository bookRepositor)
        {
            _bookRepositor = bookRepositor;
        }

        public void AddBook(Book user)
        {
            _bookRepositor.AddBook(user);
        }

        public void DeleteBook(int id)
        {
            _bookRepositor.DeleteBook(id);
        }

        public IEnumerable <Book> GetBooks()
        {
            return _bookRepositor.GetBooks();
        }

        public Book GetById(int id)
        {
            return _bookRepositor.GetById(id);
        }

        public void UpdateBook(int id, Book user)
        {
            _bookRepositor.UpdateBook(id, user);
        }
    }
}
