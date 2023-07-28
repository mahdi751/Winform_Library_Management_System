using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface IBookRepository
    {
        public Task<ICollection<Book>> GetAllBooks();
        public Task<ICollection<Book>> GetAllBooksByTitle(string title);
        public Task<ICollection<Book>> GetAllBooksByAuthorName(string title);
        public Task<Book> GetBookByISBN(string isbn);
        public Task<bool> Save();

    }
}
