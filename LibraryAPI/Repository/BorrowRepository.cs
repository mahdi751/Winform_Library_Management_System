using LibraryAPI.Data;
using LibraryAPI.DTOs;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Linq;

namespace LibraryAPI.Repository
{
    public class BorrowRepository : IBorrowRepository
    {
        private readonly DataContext _context;

        public BorrowRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Borrow>> GetBookBorrowRecords(int bookid, int userid)
        {
            List<int> memberships = await _context.Memberships
                .Where(m => m.User_UserID == userid)
                .Select(m => m.MembershipID)
                .ToListAsync();

            return await _context.Borrows
                .Where(b => b.Book_BookID == bookid && memberships.Contains(b.Membership_MembershipID))
                .ToListAsync();   
        }

        public async Task<Borrow> GetBorrowRecordByMembership(int bookid, int membershipID)
        {
            return await _context.Borrows
                .Where(b => b.Book_BookID == bookid && membershipID == b.Membership_MembershipID)
                .FirstOrDefaultAsync();

        }

        public async Task<bool> BorrowBook(Borrow borrowedBook)
        {
            await _context.Borrows.AddAsync(borrowedBook);
            return await Save();
        }

        public async Task<bool> CalculateAllOverdueFines()
        {
            var overdueBorrows = await _context.Borrows
                .Where(b => !b.IsReturned && b.ReturnDate < DateTime.Today)
                .ToListAsync();

            if (overdueBorrows.Count == 0)
            {
                return true;
            }

            foreach (var borrow in overdueBorrows)
            {
                var overdueDays = (int)(DateTime.Today - borrow.ReturnDate).TotalDays;
                borrow.Overduefine = overdueDays;

                _context.Borrows.Update(borrow);
            }

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateOverdueFines(int userid)
        {
            var overdueFinesRecs = await _context.Borrows.Where
                                    (br => _context.Memberships.Any(
                                    m => m.User_UserID == userid &&
                                    m.MembershipID == br.Membership_MembershipID &&
                                    br.Overduefine > 0))
                                    .ToListAsync();

            if (overdueFinesRecs.Count == 0)
                return true;

            foreach (var borrowed in overdueFinesRecs)
            {
                borrowed.Overduefine = 0;

                _context.Borrows.Update(borrowed);
            }

            if (!await Save())
                return false;

            return true;

        }

        public async Task<decimal> GetCurrentTotalOverduePayments(int membershipID)
        {
            return await _context.Borrows.Where(b => b.Membership_MembershipID == membershipID)
                                         .SumAsync(b => b.Overduefine);
                                   
        }

        public async Task<ICollection<OverdueBooksDetailsDTO>> GetOverduePaymentsDetails(int membershipID)
        {
            await CalculateAllOverdueFines();

            var booksOverdueDetails = await _context.Borrows
                .Where(b => !b.IsReturned 
                            && b.ReturnDate < DateTime.Today
                            && b.Membership_MembershipID == membershipID)
                .Join(_context.Books,
                      borrow => borrow.Book_BookID,
                      book => book.Bookid,
                      (borrow, book) => new OverdueBooksDetailsDTO
                      {
                          Title = book.Booktitle,
                          Isbn = book.Isbn,
                          OverdueFine = borrow.Overduefine,
                          CurrentDate = DateTime.Today,
                          ReturnDate = borrow.ReturnDate,
                          DaysLate = (int)(DateTime.Today - borrow.ReturnDate).TotalDays
                      })
                .ToListAsync();

            return booksOverdueDetails;
        }

        public async Task<ICollection<Book>> GetOverdueBooks(int membershipID)
        {
            List<int> overdueBookIds = await _context.Borrows
               .Where(b => b.Membership_MembershipID == membershipID
                        && b.ReturnDate < DateTime.Today
                        && b.Overduefine > 0)
               .Select(b => b.Book_BookID)
               .ToListAsync();

            List<Book> overdueBooks = await _context.Books
                .Where(b => overdueBookIds.Contains(b.Bookid))
                .ToListAsync();

            return overdueBooks;
        }

        public async Task<ICollection<Book>> GetUnReturnedBooks(int membershipID)
        {
            List<int> unreturned = await _context.Borrows
               .Where(b => b.Membership_MembershipID == membershipID
                        && !b.IsReturned)
               .Select(b => b.Book_BookID)
               .ToListAsync();

            List<Book> unReturnedBooks = await _context.Books
                .Where(b => unreturned.Contains(b.Bookid))
                .ToListAsync();

            return unReturnedBooks;
        }

        public async Task<ICollection<Book>> GetReturnedBooks(int membershipID)
        {
            List<int> returned = await _context.Borrows
               .Where(b => b.Membership_MembershipID == membershipID
                        && b.IsReturned)
               .Select(b => b.Book_BookID)
               .ToListAsync();

            List<Book> ReturnedBooks = await _context.Books
                .Where(b => returned.Contains(b.Bookid))
                .ToListAsync();

            return ReturnedBooks;
        }

        public async Task<ICollection<Book>> GetBorrowedBooks(int membershipID)
        {
            List<int> borrowList = await _context.Borrows
               .Where(b => b.Membership_MembershipID == membershipID)
               .Select(b => b.Book_BookID)
               .ToListAsync();

            List<Book> borrowedBooks = await _context.Books
                .Where(b => borrowList.Contains(b.Bookid))
                .ToListAsync();

            return borrowedBooks;
        }

        public async Task<ICollection<Book>> GetBorrowedBooksByUser(int userID)
        {
            List<int> borrowList = await _context.Borrows
                .Where(br => _context.Memberships.Any(
                    m => m.User_UserID == userID &&
                    br.Membership_MembershipID == m.MembershipID
                    ))
                .Select(br => br.Book_BookID)
                .ToListAsync();

            List<Book> borrowedBooks = await _context.Books
                .Where(b => borrowList.Contains(b.Bookid))
                .ToListAsync();

            return borrowedBooks;
        }

        public async Task<bool> UpdateBorrowedBook(Borrow borrowedBook)
        {
            _context.Borrows.Update(borrowedBook);
            return await Save();
        }

        public async Task<Borrow> GetBorrowedBookByMembershipID_BookID(int membershipID, int bookid)
        {
            return await _context.Borrows.Where(br => br.Book_BookID == bookid && br.Membership_MembershipID == membershipID).FirstOrDefaultAsync();
        }

        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }
    }
}
