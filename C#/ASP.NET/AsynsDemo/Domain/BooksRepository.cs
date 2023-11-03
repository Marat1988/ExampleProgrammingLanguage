using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AsynsDemo.Domain
{
    public class BooksRepository
    {
        private readonly AppDbContext context;
        public BooksRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Book> GetBooks()
        {
            IEnumerable<Book> result = context.Books.ToList();
            return result;
        }
        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            IEnumerable<Book> result = await context.Books.ToListAsync();
            return result;
        }
        public Book GetBookById(int id)
        {
            Book result = context.Books.FirstOrDefault(x => x.Id == id);
            return result;
        }
        public async Task<Book> GetBookByIdAsync(int id)
        {
            Book result = await context.Books.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
        public void SaveBook(Book book)
        {
            context.Entry(book).State = EntityState.Added;
            context.SaveChanges();
        }
        public async Task SaveBookAsync(Book book)
        {
            context.Entry(book).State = EntityState.Added;
            await context.SaveChangesAsync();
        }
    }
}
