
using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface IMembershipRepository
    {
        public Task<int> GetMembershipIdByUserID(int userID);
        public Task<Membership> GetMembershipByUserID(int userID);
        public Task<DateTime> GetMembershipEndDate(int membershipID);
        public Task<bool> AddMembership(Membership membership);
        public Task<bool> Save();
    }
}
