using LibraryAPI.DTOs;
using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface IBorrowRepository
    {
        public Task<IEnumerable<Borrow>> GetBookBorrowRecords(int bookid, int userid);
        public Task<Borrow> GetBorrowRecordByMembership(int bookid, int membershipID);
        public Task<bool> BorrowBook(Borrow borrowedBook);
        public Task<bool> UpdateBorrowedBook(Borrow borrowedBook);
        public Task<ICollection<BorrowDetailsDTO>> GetBorrowedBooks(int membershipID);
        public Task<ICollection<BorrowDetailsDTO>> GetBorrowedBooksByUser(int userID);
        public Task<Borrow> GetBorrowedBookByMembershipID_BookID(int membershipID,int bookid);
        public Task<ICollection<BorrowDetailsDTO>> GetUnReturnedBooks(int membershipID);
        public Task<ICollection<BorrowDetailsDTO>> GetReturnedBooks(int membershipID);
        public Task<ICollection<Book>> GetOverdueBooks(int membershipID);
        public Task<bool> Save();
        
    }
}
