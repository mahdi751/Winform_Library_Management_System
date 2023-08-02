using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface IAccountRepository
    {
        public Task<User> GetUserByUsername(string username);
        public Task<int> GetUserIDByUsername(string username);
        public Task<bool> AddUser(User user);
        public Task<bool> UpdateUser(User user);
        public Task<bool> UserExits(string username);
        public Task<bool> EmailExists(string email);
        public Task<bool> Save();
    }
}
