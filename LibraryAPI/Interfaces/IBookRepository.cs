using LibraryAPI.DTOs;
using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface IBookRepository
    {
        public Task<bool> AddBook(Book book);
        public Task<int> GetBookAvailableQuantity(int bookid);
        public Task<ICollection<BookDetailsDTO>> GetAllBooks();
        public Task<Book> GetBookById(int id);
        public Task<ICollection<BookDetailsDTO>> GetAllBooksByGenre(string genre);
        public Task<ICollection<BookDetailsDTO>> GetAllBooksByAuthorName(string name);
        public Task<Book> GetBookByISBN(string isbn);
        public Task<bool> UpdateBook(Book book);
        public Task<bool> Save();
        public Task<ICollection<BookDetailsDTO>>GetAllBooksByTitle(string title);
    }
}
