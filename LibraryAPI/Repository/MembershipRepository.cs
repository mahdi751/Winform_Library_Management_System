using LibraryAPI.Data;
using LibraryAPI.DTOs;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Repository
{
    public class MembershipRepository : IMembershipRepository
    {
        private readonly DataContext _context;

        public MembershipRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<int> GetMembershipIdByUserID(int userID)
        {
            DateTime currentDate = DateTime.Today;

            return await _context.Memberships
                .Where(m => m.User_UserID == userID && m.EndDate >= currentDate)
                .Select(m => m.MembershipID)
                .FirstOrDefaultAsync();
        }
        public async Task<Membership> GetMembershipDetailsByUserID(int userID)
        {
            DateTime currentDate = DateTime.Today;

            return await _context.Memberships
                .Where(m => m.User_UserID == userID && m.EndDate >= currentDate)
                .Select(m => new Membership
                {
                    MembershipName = m.MembershipName,
                    MaxBorrowLimit = m.MaxBorrowLimit,
                    RemainingBorrowAbility = m.RemainingBorrowAbility,
                    MembershipPrice = m.MembershipPrice,
                    StartDate = m.StartDate,
                    EndDate = m.EndDate
                })
                .FirstOrDefaultAsync();
        }

        public async Task<DateTime> GetMembershipEndDate(int membershipID)
        {
            DateTime currentDate = DateTime.Today;

            var membership = await _context.Memberships
                .Where(m => m.MembershipID == membershipID)
                .Select(m => m.EndDate)
                .FirstOrDefaultAsync();

            return membership;
        }

        public async Task<bool> AddMembership(Membership membership)
        {
            await _context.Memberships.AddAsync(membership);
            return true;
        }

        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }

        public async Task<bool> UpdateMembership(Membership membership)
        {
            _context.Memberships.Update(membership);
            return true;
        }

        public async Task<Membership> GetMembershipByMembershipID(int membership)
        {
            return await _context.Memberships.Where(m => m.MembershipID == membership).FirstOrDefaultAsync();
        }

        public async Task<Membership> GetLastMembershipByUserID(int userID)
        {
            return await _context.Memberships
                .Where(m => m.User_UserID == userID)
                .OrderByDescending(m => m.MembershipID)
                .FirstOrDefaultAsync();
        }


        public async Task<string> GetUsernameByMembershipID(int membershipID)
        {
            return await _context.Users.Where(u => _context.Memberships
                   .Any(m => m.User_UserID == u.UserID && m.MembershipID == membershipID))
                   .Select(u => u.Username)
                   .FirstOrDefaultAsync();
        }

        public async Task<int> GetMembershipRemainingBorrowAbility(int membershiID)
        {
            return _context.Memberships
                .Where(m =>m.MembershipID == membershiID)
                .Select(m => m.RemainingBorrowAbility)
                .FirstOrDefault();

        }
    }
}
