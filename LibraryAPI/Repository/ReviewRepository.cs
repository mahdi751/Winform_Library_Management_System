using LibraryAPI.Data;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

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
            return await _context.Reviews
                .Where(r => r.Book_BookID == bookID)
                .ToListAsync();
        }






        public async Task<Review> GetReviewByBookID_UserID(int bookID, int userID)
        {
            return await _context.Reviews.Where(
                    r => _context.Memberships.Any(
                    m => m.MembershipID == r.Membership_MembershipID &&
                    m.User_UserID == userID &&
                    r.Book_BookID == bookID
                    ))
                    .FirstOrDefaultAsync();
        }

        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }

        public async Task<bool> UpdateReview(Review review)
        {
            _context.Reviews.Update(review);
            return await Save();
        }
    }
}
