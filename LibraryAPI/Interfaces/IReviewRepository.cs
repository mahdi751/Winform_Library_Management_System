using LibraryAPI.DTOs;
using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface IReviewRepository
    {
        public Task<bool> AddReview(Review review);
        public Task<int> GetBookAverageRating(int bookid);
        public Task<ICollection<ReviewDetailsDTO>> GetAllReviewsOfaBook(int bookID);
        public Task<Review> GetReviewByBookID_UserID(int bookID,int userID);
        public Task<bool> UpdateReview(Review review);
        public Task<bool> Save();

    }
}
