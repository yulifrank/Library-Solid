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
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Book> AddBookAsync(Book user)
        {
           await  _bookRepository.AddBookAsync(user);
            return user;
        }

        public async Task DeleteBookAsync(int id)
        {
           await _bookRepository.DeleteBookAsync(id);
        }

        public IEnumerable <Book> GetBooks()
        {
            return _bookRepository.GetBooks();
        }

        public Book GetById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public async Task<Book> UpdateBookAsync(int id, Book user)
        {
           await _bookRepository.UpdateBookAsync(id, user);
            return user;
        }
    }
}
