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
        private readonly IPaymentRepository _paymentRepository;

        public BorrowRepository(DataContext context,IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
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

        public async Task<ICollection<BorrowDetailsDTO>> GetUnReturnedBooks(int membershipID)
        {
            var success = await _paymentRepository.CalculateOverdueFinesByMembershipID(membershipID);
            if (success)
            {
                var unreturned = await _context.Borrows
                .Where(br => br.Membership_MembershipID == membershipID && !br.IsReturned)
                .Join(_context.Books,
                book => book.Book_BookID,
                borrow => borrow.Bookid,
                (borrow, book) => new BorrowDetailsDTO
                {
                    Bookid = book.Bookid,
                    Booktitle = book.Booktitle,
                    Genre = book.Genre,

                    AuthorName = _context.BookAuthors
                        .Where(ba => ba.Book_BookID == book.Bookid)
                        .Join(_context.Authors,
                        ba => ba.Author_AuthorID,
                        author => author.AuthorID,
                        (ba, author) => author.AuthorName)
                        .FirstOrDefault(),

                    IsReturned = borrow.IsReturned,
                    PickupDate = borrow.PickupDate,
                    ReturnDate = borrow.ReturnDate,
                    Fine = borrow.Overduefine
                })
                .ToListAsync();

                return unreturned;
            }

            return null;
        }

        public async Task<ICollection<BorrowDetailsDTO>> GetReturnedBooks(int membershipID)
        {
            var returned = await _context.Borrows
               .Where(br => br.Membership_MembershipID == membershipID && br.IsReturned)
               .Join(_context.Books,
               book => book.Book_BookID,
               borrow => borrow.Bookid,
               (borrow, book) => new BorrowDetailsDTO
               {
                   Bookid = book.Bookid,
                   Booktitle = book.Booktitle,
                   Genre = book.Genre,

                   AuthorName = _context.BookAuthors
                       .Where(ba => ba.Book_BookID == book.Bookid)
                       .Join(_context.Authors,
                       ba => ba.Author_AuthorID,
                       author => author.AuthorID,
                       (ba, author) => author.AuthorName)
                       .FirstOrDefault(),

                   IsReturned = borrow.IsReturned,
                   PickupDate = borrow.PickupDate,
                   ReturnedDate = borrow.ReturnedDate
               })
               .ToListAsync();

            return returned;

        }

        public async Task<ICollection<BorrowDetailsDTO>> GetBorrowedBooks(int membershipID)
        {
            var borrowList = await _context.Borrows
                .Where(br => br.Membership_MembershipID == membershipID)
                .Join(_context.Books,
                book => book.Book_BookID,
                borrow => borrow.Bookid,
                (borrow, book) => new BorrowDetailsDTO
                {
                    Bookid = book.Bookid,
                    Booktitle = book.Booktitle,
                    Genre = book.Genre,

                    AuthorName = _context.BookAuthors
                        .Where(ba => ba.Book_BookID == book.Bookid)
                        .Join(_context.Authors,
                        ba => ba.Author_AuthorID,
                        author => author.AuthorID,
                        (ba, author) => author.AuthorName)
                        .FirstOrDefault(),

                    IsReturned = borrow.IsReturned,
                    PickupDate = borrow.PickupDate,
                    ReturnedDate = borrow.ReturnedDate,
                    ReturnDate = borrow.ReturnDate
                })
                .ToListAsync();

            return borrowList;
        }

        public async Task<ICollection<BorrowDetailsDTO>> GetBorrowedBooksByUser(int userID)
        {
            var borrowList = await _context.Borrows
               .Where(br => _context.Memberships.Any(
                    m => m.User_UserID == userID &&
                    br.Membership_MembershipID == m.MembershipID
                    ))
               .Join(_context.Books,
               book => book.Book_BookID,
               borrow => borrow.Bookid,
               (borrow, book) => new BorrowDetailsDTO
               {
                   Bookid = book.Bookid,
                   Booktitle = book.Booktitle,
                   Genre = book.Genre,

                   AuthorName = _context.BookAuthors
                       .Where(ba => ba.Book_BookID == book.Bookid)
                       .Join(_context.Authors,
                       ba => ba.Author_AuthorID,
                       author => author.AuthorID,
                       (ba, author) => author.AuthorName)
                       .FirstOrDefault(),

                   IsReturned = borrow.IsReturned,
                   PickupDate = borrow.PickupDate,
                   ReturnedDate = borrow.ReturnedDate,
                   ReturnDate = borrow.ReturnDate
               })
               .ToListAsync();

            return borrowList;
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
