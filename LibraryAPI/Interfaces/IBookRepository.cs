using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface IBookRepository
    {
        public Task<bool> AddBook(Book book);
        public Task<ICollection<Book>> GetAllBooks();
        public Task<Book> GetBookById(int id);
        public Task<ICollection<Book>> GetAllBooksByTitle(string title);
        public Task<ICollection<Book>> GetAllBooksByGenre(string genre);
        public Task<ICollection<Book>> GetAllBooksByAuthorName(string name);
        public Task<Book> GetBookByISBN(string isbn);
        public Task<bool> UpdateBook(Book book);
        public Task<bool> Save();

    }
}
