using LibraryAPI.Data;
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
            return await Save();

        }

        public async Task<ICollection<PaymentHistory>> GetPaymentHistories(int userid)
        {
            return await _context.PaymentHistories
                   .Where(ph => ph.User_UserID == userid)
                   .ToListAsync();
        }

        public async Task<ICollection<PaymentHistory>> GetPaymentHistoriesByType(int userid, string type)
        {
            return await _context.PaymentHistories
                   .Where(ph => ph.User_UserID == userid && ph.PaymentType == type)
                   .ToListAsync();
        }

        public async Task<decimal> GetTotalPayments()
        {
            return await _context.PaymentHistories
                .SumAsync(ph => ph.Amount);
        }

        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }
    }
}
