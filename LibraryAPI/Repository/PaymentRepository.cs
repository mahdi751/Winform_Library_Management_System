using LibraryAPI.Data;
using LibraryAPI.DTOs;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly DataContext _context;

        public PaymentRepository(DataContext context) 
        {
            _context = context;
        }

        public async Task<bool> AddPayment(PaymentHistory paymentHistory)
        {
            await _context.PaymentHistories.AddAsync(paymentHistory);
            return true;

        }

        public async Task<ICollection<PaymentHistory>> GetPaymentHistories(int userid)
        {
            return await _context.PaymentHistories
                .Where(ph => _context.Memberships.Any(
                       m => m.User_UserID == userid && m.MembershipID == ph.Membership_MembershipID))
                   .ToListAsync();
        }

        public async Task<ICollection<PaymentHistory>> GetPaymentHistoriesByType(int userid, string type)
        {
            return await _context.PaymentHistories
                .Where(ph => _context.Memberships.Any(
                       m => m.User_UserID == userid && m.MembershipID == ph.Membership_MembershipID && ph.PaymentType == type))
                   .ToListAsync();
        }

        public async Task<double> GetTotalPayments()
        {
            return await _context.PaymentHistories
                .SumAsync(ph => ph.Amount);
        }

        public async Task<bool> CalculateOverdueFinesByMembershipID(int membershipID)
        {
            var overdueBorrows = await _context.Borrows
                .Where(b => !b.IsReturned && b.ReturnDate < DateTime.Today && b.Membership_MembershipID == membershipID)
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

            if(await Save())
                return true;

            return false;
        }

        public async Task<bool> PayBookFines(int bookid,int membershipID)
        {
            var borrowRec = await _context.Borrows.Where(br => br.Book_BookID == bookid && br.Membership_MembershipID == membershipID).FirstOrDefaultAsync();
            borrowRec.Overduefine = 0;
            borrowRec.ReturnDate = DateTime.Today;

            _context.Borrows.Update(borrowRec);

            return await Save();

        }

        public async Task<bool> UpdateOverdueFines(int membershipID)
        {
            var overdueFinesRecs = await _context.Borrows.Where
                                    (br => br.Membership_MembershipID == membershipID &&
                                    br.Overduefine > 0)
                                    .ToListAsync();

            if (overdueFinesRecs.Count == 0)
                return false;

            foreach (var borrowed in overdueFinesRecs)
            {
                borrowed.Overduefine = 0;
                borrowed.ReturnDate = DateTime.Today;

                _context.Borrows.Update(borrowed);
            }

            if (!await Save())
                return false;

            return true;

        }
        public async Task<int> GetOverdueFineByBookID(int bookID,int membershipID)
        {
            return await _context.Borrows.Where(br => br.Book_BookID == bookID && br.Membership_MembershipID == membershipID)
                .Select(br => br.Overduefine)
                .FirstOrDefaultAsync();
        }

        public async Task<decimal> GetCurrentTotalOverduePayments(int membershipID)
        {
            return await _context.Borrows.Where(b => b.Membership_MembershipID == membershipID)
                                         .SumAsync(b => b.Overduefine);

        }

        public async Task<ICollection<OverdueBooksDetailsDTO>> GetOverduePaymentsDetails(int membershipID)
        {
            await CalculateOverdueFinesByMembershipID(membershipID);

            var booksOverdueDetails = await _context.Borrows
                .Where(b => !b.IsReturned
                            && b.ReturnDate < DateTime.Today
                            && b.Membership_MembershipID == membershipID)
                .Join(_context.Books,
                      borrow => borrow.Book_BookID,
                      book => book.Bookid,
                      (borrow, book) => new OverdueBooksDetailsDTO
                      {
                          bookID = book.Bookid,
                          Title = book.Booktitle,
                          Genre = book.Genre,
                          OverdueFine = borrow.Overduefine,
                          PickUpDate = borrow.PickupDate,
                          CurrentDate = DateTime.Today,
                          ReturnDate = borrow.ReturnDate,
                          DaysLate = (int)(DateTime.Today - borrow.ReturnDate).TotalDays,

                          Author = _context.BookAuthors
                                   .Where(ba => ba.Book_BookID == book.Bookid)
                                   .Join(_context.Authors,
                                   ba => ba.Author_AuthorID,
                                   a => a.AuthorID,
                                   (ba,a) => a.AuthorName)
                                   .FirstOrDefault(),
                      })
                .ToListAsync();

            return booksOverdueDetails;
        }

        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }
    }
}
