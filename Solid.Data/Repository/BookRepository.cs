﻿using Solid.Core.Entities;
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
        public Book AddBook(Book book)
        {
            _context.Books.Add(book);
            return book;
        }

        public void DeleteBook(int id)
        {
            var temp = _context.Books.Find(x => x.BookId == id);
            _context.Books.Remove(temp);
        }

        public List<Book> GetBooks()
        {
            return _context.Books;
        }

        public Book GetById(int id)
        {
            return _context.Books.Find(u => u.BookId == id);
        }

        public Book UpdateBook(int id, Book book)
        {
            var temp = _context.Books.Find(u => u.BookId == id);
            temp = book;
            return temp;
        }
    }
}
