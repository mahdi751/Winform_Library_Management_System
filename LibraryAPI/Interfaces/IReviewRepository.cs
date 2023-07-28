using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface IReviewRepository
    {
        public Task<bool> AddReview(Review review);
        public Task<ICollection<Review>> GetAllReviewsOfaBook(int bookID);
        public Task<bool> Save();

    }
}
