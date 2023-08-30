using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface IPaymentRepository
    {
        public Task<bool> PayFines(PaymentHistory paymentHistory);
        public Task<ICollection<PaymentHistory>> GetPaymentHistoriesByType(int userid,string type);
        public Task<ICollection<PaymentHistory>> GetPaymentHistories(int userid);
        public Task<double> GetTotalPayments();
    }
}
