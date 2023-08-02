using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface IReviewRepository
    {
        public Task<bool> AddReview(Review review);
        public Task<ICollection<Review>> GetAllReviewsOfaBook(int bookID);
        public Task<Review> GetReviewByBookID_UserID(int bookID,int userID);
        public Task<bool> UpdateReview(Review review);
        public Task<bool> Save();

    }
}
