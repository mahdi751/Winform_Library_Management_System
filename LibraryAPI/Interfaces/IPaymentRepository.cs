using LibraryAPI.DTOs;
using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface IPaymentRepository
    {
        public Task<bool> AddPayment(PaymentHistory paymentHistory);
        public Task<ICollection<PaymentHistory>> GetPaymentHistoriesByType(int userid,string type);
        public Task<ICollection<PaymentHistory>> GetPaymentHistories(int userid);
        public Task<double> GetTotalPayments();

        public Task<bool> CalculateOverdueFinesByMembershipID(int membershipID);
        public Task<int> GetOverdueFineByBookID(int bookID,int membershipID);
        public Task<ICollection<OverdueBooksDetailsDTO>> GetOverduePaymentsDetails(int membershipID);
        public Task<decimal> GetCurrentTotalOverduePayments(int membershipID);
        public Task<bool> UpdateOverdueFines(int membershipID);
        public Task<bool> PayBookFines(int bookid, int membershipID);

        public Task<bool> Save();
    }
}
