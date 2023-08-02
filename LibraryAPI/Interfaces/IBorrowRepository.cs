using LibraryAPI.DTOs;
using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface IBorrowRepository
    {
        public Task<bool> BorrowBook(Borrow borrowedBook);
        public Task<bool> UpdateBorrowedBook(Borrow borrowedBook);
        public Task<bool> CalculateAllOverdueFines();
        public Task<ICollection<Book>> GetOverdueBooks(int membershipID);
        public Task<ICollection<OverdueBooksDetailsDTO>> GetOverduePaymentsDetails(int membershipID);
        public Task<decimal> GetCurrentTotalOverduePayments(int membershipID);
        public Task<ICollection<Book>> GetBorrowedBooks(int membershipID);
        public Task<ICollection<Book>> GetBorrowedBooksByUser(int userID);
        public Task<Borrow> GetBorrowedBookByMembershipID_BookID(int membershipID,int bookid);
        public Task<ICollection<Book>> GetUnReturnedBooks(int membershipID);
        public Task<bool> UpdateOverdueFines(int userid);
        public Task<bool> Save();
        
    }
}
