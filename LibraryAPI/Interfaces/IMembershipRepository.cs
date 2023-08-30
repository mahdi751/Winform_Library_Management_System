
using LibraryAPI.Models;

namespace LibraryAPI.Interfaces
{
    public interface IMembershipRepository
    {
        public Task<int> GetMembershipRemainingBorrowAbility(int membershiID);
        public Task<int> GetMembershipIdByUserID(int userID);
        public Task<bool> UpdateMembership(Membership membership);
        public Task<Membership> GetMembershipDetailsByUserID(int userID);
        public Task<Membership> GetMembershipByMembershipID(int membership);
        public Task<DateTime> GetMembershipEndDate(int membershipID);
        public Task<bool> AddMembership(Membership membership);
        public Task<Membership> GetLastMembershipByUserID(int userID);
        public Task<string> GetUsernameByMembershipID(int membershipID);
        public Task<bool> Save();
    }
}
