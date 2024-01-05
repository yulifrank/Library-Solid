using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IBookService
    {
         IEnumerable<Book> GetBooks();

         Book GetById(int id);
        void AddBook(Book user);

        void UpdateBook(int id, Book user);

        void DeleteBook(int id);
    }
}
