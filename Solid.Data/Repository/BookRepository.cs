using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }
        public async Task< Book> AddBookAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();  
            return book;
        }

        public async Task DeleteBookAsync(int id)
        {
            var temp = _context.Books.Find(id);
            _context.Books.Remove(temp);
          await  _context.SaveChangesAsync();
          
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books;
        }

        public Book GetById(int id)
        {
            return _context.Books.Find(id);
        }

        public async Task<Book> UpdateBookAsync(int id, Book book)
        {
            var temp = _context.Books.Find(id);
            temp = book;
           await  _context.SaveChangesAsync();
            return  temp;

        }
    }
}
