using LibraryAPI.Data;
using LibraryAPI.DTOs;
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

        public async Task<int> GetBookAverageRating(int bookid)
        {
            var hasReviews = await _context.Reviews.AnyAsync(r => r.Book_BookID == bookid);

            if (!hasReviews)
            {
                return -1;
            }

            var avgRating = await _context.Reviews
                .Where(r => r.Book_BookID == bookid)
                .AverageAsync(r => r.Rating);

            bool hasDecimal = avgRating % 1 != 0;

            if(hasDecimal && (avgRating - Math.Floor(avgRating)) < 0.5)
            {
                return (int)Math.Floor(avgRating);
            }
            else
            {
                return (int)Math.Ceiling(avgRating);
            }
        }

        public async Task<ICollection<ReviewDetailsDTO>> GetAllReviewsOfaBook(int bookID)
        {
            return await _context.Reviews
                .Where(r => r.Book_BookID == bookID)
                .Select( r => new ReviewDetailsDTO
                {
                    BookID = r.Book_BookID,
                    MembershipID = r.Membership_MembershipID,
                    Comment = r.Comment,
                    Rating = r.Rating,
                    ReviewDate = r.ReviewDate,

                    Username = _context.Memberships
                    .Where(m => m.MembershipID == r.Membership_MembershipID)
                    .Join(_context.Users,
                    m => m.User_UserID,
                    u => u.UserID,
                    (m,u) => u.Username)
                    .FirstOrDefault()
                })
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
