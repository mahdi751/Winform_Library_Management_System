namespace LibraryAPI.Interfaces
{
    public interface IAuthorRepository
    {
        public Task<string> GetAuthorByBookID(int bookID);
    }
}
