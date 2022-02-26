using LibApp.Data;
using LibApp.Interfaces;
using LibApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
        }

        public List<Book> GetAllBooks()
        {
            var result = _context.Books
                .Include(b => b.Genre)
                .ToList();

            return result;
        }

        public List<Genre> GetAllGenre()
        {
            return _context.Genre.ToList();
        }

        public Book GetBookById(int id)
        {
            var result = _context.Books
                .Include(b => b.Genre)
                .SingleOrDefault(b => b.Id == id);

            return result;
        }

        public List<Book> GetBookByPrefixMatch(string name)
        {
            var result = _context.Books.Where(b => b.Name.Contains(name));
            return result as List<Book>;
        }

        public int Save()
        { 
            return _context.SaveChanges();
        }
    }
}
