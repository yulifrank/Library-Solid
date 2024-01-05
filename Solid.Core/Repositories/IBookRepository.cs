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

        Book AddBook(Book user);

        Book UpdateBook(int id, Book user);

        void DeleteBook(int id);
    }
}
