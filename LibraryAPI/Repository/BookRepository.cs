﻿using LibraryAPI.Data;
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

        public async Task<ICollection<Book>> GetAllBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<ICollection<Book>> GetAllBooksByTitle(string title)
        {
            return await _context.Books.Where(b => b.Booktitle.ToLower().Contains(title.ToLower())).ToListAsync();
        }

        public async Task<ICollection<Book>> GetAllBooksByGenre(string genre)
        {
            return await _context.Books.Where(b => b.Genre.ToLower().Contains(genre.ToLower())).ToListAsync();
        }

        public async Task<ICollection<Book>> GetAllBooksByAuthorName(string name)
        {
            var booksByAuthor = await _context.Books
                .Where(b => _context.BookAuthors
                    .Any(ba => ba.Book_BookID == b.Bookid
                        && ba.Author_AuthorID == _context.Authors
                            .Where(a => a.AuthorName.ToLower().Contains(name.ToLower()))
                            .Select(a => a.AuthorID)
                            .FirstOrDefault()))
                .ToListAsync();

            return booksByAuthor;
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
    }
}
