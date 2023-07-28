using LibraryAPI.Data;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DataContext _context;

        public ReviewRepository(DataContext context) 
        {
            _context = context;
        }

        public async Task<bool> AddReview(Review review)
        {
            await _context.Reviews.AddAsync(review);
            return await Save();
        }

        public async Task<ICollection<Review>> GetAllReviewsOfaBook(int bookID)
        {
            return await _context.Reviews.Where(r => r.Book_BookID == bookID).ToListAsync();
        }

        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }

    }
}
