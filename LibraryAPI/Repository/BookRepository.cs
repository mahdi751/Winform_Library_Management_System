using LibraryAPI.Data;
using LibraryAPI.DTOs;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;
        public BookRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> AddBook(Book book)
        {
            await _context.Books.AddAsync(book);
            return await Save();
        }

        public async Task<int> GetBookAvailableQuantity(int bookid)
        {
            return await _context.Books.Where(b => b.Bookid == bookid).Select(b => b.AvailableQuantity).FirstOrDefaultAsync();
        }

        public async Task<ICollection<BookDetailsDTO>> GetAllBooks()
        {
            var booksDetails = await _context.Books
                .Select(book => new BookDetailsDTO
                {
                    Bookid = book.Bookid,
                    AvailableQuantity = book.AvailableQuantity,
                    Booktitle = book.Booktitle,
                    Publicationdate = book.Publicationdate,
                    Genre = book.Genre,
                    Publishername = book.Publishername,

                    AuthorName = _context.BookAuthors
                    .Where(ba => ba.Book_BookID == book.Bookid)
                    .Join(_context.Authors,
                    ba => ba.Author_AuthorID,
                    author => author.AuthorID,
                    (ba, author) => author.AuthorName)
                    .FirstOrDefault()
                })
                .ToListAsync();

            return booksDetails;
        }

        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }

        public async Task<Book> GetBookByISBN(string isbn)
        {
            return await _context.Books.Where(b => b.Isbn == isbn).FirstOrDefaultAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _context.Books.Where(b => b.Bookid == id).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateBook(Book book)
        {
            _context.Books.Update(book);
            return await Save();
        }

        public async Task<ICollection<BookDetailsDTO>> GetAllBooksByTitle(string title)
        {
            var booksDetails = await _context.Books
                .Where(b => b.Booktitle.ToLower().Contains(title.ToLower()))
                .Select(book => new BookDetailsDTO
                {
                    Bookid = book.Bookid,
                    AvailableQuantity = book.AvailableQuantity,
                    Booktitle = book.Booktitle,
                    Publicationdate = book.Publicationdate,
                    Genre = book.Genre,
                    Publishername = book.Publishername,

                    AuthorName = _context.BookAuthors
                    .Where(ba => ba.Book_BookID == book.Bookid)
                    .Join(_context.Authors,
                    ba => ba.Author_AuthorID,
                    author => author.AuthorID,
                    (ba, author) => author.AuthorName)
                    .FirstOrDefault()
                })
                .ToListAsync();

            return booksDetails;
        }
        public async Task<ICollection<BookDetailsDTO>> GetAllBooksByGenre(string genre)
        {
            var booksDetails = await _context.Books
                .Where(b => b.Genre.ToLower()
                .Contains(genre.ToLower()))
                .Select(book => new BookDetailsDTO
                {
                    Bookid = book.Bookid,
                    AvailableQuantity = book.AvailableQuantity,
                    Booktitle = book.Booktitle,
                    Publicationdate = book.Publicationdate,
                    Genre = book.Genre,
                    Publishername = book.Publishername,

                    AuthorName = _context.BookAuthors
                    .Where(ba => ba.Book_BookID == book.Bookid)
                    .Join(_context.Authors,
                    ba => ba.Author_AuthorID,
                    author => author.AuthorID,
                    (ba,author) => author.AuthorName)
                    .FirstOrDefault()
                })
                .ToListAsync();

            return booksDetails;
        }
        public async Task<ICollection<BookDetailsDTO>> GetAllBooksByAuthorName(string name)
        {
            var booksDetails = await _context.Books
                .Where(b => _context.BookAuthors
                    .Any(ba => ba.Book_BookID == b.Bookid
                        && ba.Author_AuthorID == _context.Authors
                            .Where(a => a.AuthorName.ToLower().Contains(name.ToLower()))
                            .Select(a => a.AuthorID)
                            .FirstOrDefault()))
                .Select(book => new BookDetailsDTO
                {
                    Bookid = book.Bookid,
                    AvailableQuantity = book.AvailableQuantity,
                    Booktitle = book.Booktitle,
                    Publicationdate = book.Publicationdate,
                    Genre = book.Genre,
                    Publishername = book.Publishername,

                    AuthorName = _context.BookAuthors
                    .Where(ba => ba.Book_BookID == book.Bookid)
                    .Join(_context.Authors,
                    bookAuthor => bookAuthor.Author_AuthorID,
                    author => author.AuthorID,
                    (bookAuthor, author) => author.AuthorName)
                    .FirstOrDefault()
                })
                .ToListAsync();

            return booksDetails;
        }

    }
}
