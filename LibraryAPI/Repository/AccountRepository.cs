using LibraryAPI.Data;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _context;
        public AccountRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await _context.Users.Where(u => u.Username == username).FirstOrDefaultAsync();
        }

        public async Task<int> GetUserIDByUsername(string username)
        {
            return await _context.Users.Where(u => u.Username == username)
                                       .Select(u => u.UserID)
                                       .FirstOrDefaultAsync();
        }

        public async Task<bool> UserExits(string username)
        {
            return await _context.Users.AnyAsync(x => x.Username == username.ToLower());
        }
        public async Task<bool> EmailExists(string email)
        {
            return await _context.Users.AnyAsync(x => x.Email == email.ToLower());
        }
        public async Task<bool> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            return await Save();
        }
        public async Task<bool> UpdateUser(User user)
        {
            _context.Users.Update(user);
            return await Save();
        }
        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }

    }
}
