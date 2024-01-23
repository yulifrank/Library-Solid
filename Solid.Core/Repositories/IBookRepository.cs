using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IBookRepository
    {
            
        IEnumerable<Book> GetBooks();

        Book GetById(int id);

        Task<Book> AddBookAsync(Book user);

        Task<Book> UpdateBookAsync(int id, Book user);

        Task DeleteBookAsync(int id);
    }
}


