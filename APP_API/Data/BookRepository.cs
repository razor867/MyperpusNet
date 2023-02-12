using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APP_API.Model;
using APP_API.ViewModel;
using Microsoft.Data.SqlClient;
using APP_API.Helpers;

namespace APP_API.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;
        public BookRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<book>> GetListBooks(Params prm)
        {
            return await _context.book.ToListAsync();
        }
        public async Task<book> GetBookById(string id)
        {
            return await _context.book
                .FirstOrDefaultAsync(x => x.book_id == id);
        }
    }
}
