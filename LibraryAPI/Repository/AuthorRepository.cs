using LibraryAPI.Data;
using LibraryAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Repository
{
    public class AuthorRepository : IAuthorRepository
    {

        private readonly DataContext _context;
        public AuthorRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<string> GetAuthorByBookID(int bookid)
        {
            return await _context.Authors
                         .Where(a => _context.BookAuthors
                         .Any(ba => ba.Book_BookID == bookid && ba.Author_AuthorID == a.AuthorID))
                         .Select(a => a.AuthorName)
                         .FirstOrDefaultAsync();
        }
    }
}
