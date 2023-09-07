using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using LibraryAPI.DTOs;
using LibraryAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using LibraryAPI.Data;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembershipController : ControllerBase
    {
        private readonly IMembershipRepository _membershipRepository;
        private readonly IPaymentRepository _paymentRepository;
        private readonly DataContext _context;

        public MembershipController(IMembershipRepository membershipRepository, IPaymentRepository paymentRepository,DataContext context)
        {
            _membershipRepository = membershipRepository;
            _paymentRepository = paymentRepository;
            _context = context;
        }

        [HttpGet("GetLastMembership/{userID}")]
        public async Task<IActionResult> GetLastMembership(int userID)
        {
            var membership = await _membershipRepository.GetLastMembershipByUserID(userID);
            return Ok(membership);
        }

        [HttpGet("GetMembershipRemainingBorrowAbility/{membershiID}")]
        public async Task<IActionResult> GetMembershipRemainingBorrowAbility(int membershiID)
        {
            var RemainingBorrowAbility = await _membershipRepository.GetMembershipRemainingBorrowAbility(membershiID);
            return Ok(RemainingBorrowAbility);
        }

        [HttpGet("GetUsernameByMembership/{membershipID}")]
        public async Task<IActionResult> GetUsernameByMembership(int membershipID)
        {
            var username = await _membershipRepository.GetUsernameByMembershipID(membershipID);
            return Ok(username);
        }

        [HttpGet("GetMembershipByUserID/{userID}")]
        public async Task<IActionResult> GetMembershipByUserID(int userID)
        {
            var membership = await _membershipRepository.GetMembershipDetailsByUserID(userID);
            if (membership == null)
            {
                throw new MembershipExceptions.MembershipNotFoundException("Membership must be renewed or purshased.");
            }
            return Ok(membership);
        }

        [HttpGet("enddate/{membershipID}")]
        public async Task<IActionResult> GetMembershipEndDate(int membershipID)
        {
            var endDate = await _membershipRepository.GetMembershipEndDate(membershipID);
            if (endDate == default)
            {
                throw new MembershipExceptions.MembershipEndDateNotFoundException("Membership end date not found.");
            }
            return Ok(endDate);
        }

        [HttpGet("GetMembershipID/{userID}")]
        public async Task<IActionResult> GetMembershipIdByUserID(int userID)
        {
            var membershipId = await _membershipRepository.GetMembershipIdByUserID(userID);
            if (membershipId == 0)
            {
                throw new MembershipExceptions.MembershipNotFoundException("Membership must be renewed or purshased");
            }
            return Ok(membershipId);
        }

        [HttpPost("MembershipSubscription")]
        public async Task<IActionResult> SubscribeToMembership([FromBody] MembershipDTO newMembershipDTO)
        {
            try
            {
                if (!ModelState.IsValid || newMembershipDTO == null)
                {
                    throw new MembershipExceptions.MembershipCreationException("Invalid membership data.");
                }

                var membership = new Membership
                {
                    MembershipName = newMembershipDTO.MembershipName,
                    MaxBorrowLimit = newMembershipDTO.MaxBorrowLimit,
                    MembershipPrice = newMembershipDTO.MembershipPrice,
                    RemainingBorrowAbility = newMembershipDTO.MaxBorrowLimit,
                    User_UserID = newMembershipDTO.User_UserID,
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(30)
                };

                var membershipSuccess = await _membershipRepository.AddMembership(membership);

                if (await _membershipRepository.Save())
                {
                    var savedMembership = await _membershipRepository.GetLastMembershipByUserID(membership.User_UserID);

                    var payment = new PaymentHistory
                    {
                        Amount = membership.MembershipPrice,
                        PaymentDate = DateTime.Today,
                        PaymentType = "membership",
                        Membership_MembershipID = savedMembership.MembershipID
                    };

                    var paymentSuccess = await _paymentRepository.AddPayment(payment);

                    if (await _paymentRepository.Save())
                        return Ok(savedMembership);

                    return BadRequest();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
                throw new Exception("Exception: " + ex);
            }
        }



        [HttpPut("RenewCurrentMembership")]
        public async Task<IActionResult> RenewMembership([FromBody] int userid)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var membership = await _membershipRepository.GetLastMembershipByUserID(userid);
                    membership.EndDate = DateTime.Today.AddDays(30);
                    membership.RemainingBorrowAbility = membership.MaxBorrowLimit;

                    var membershipSuccess = await _membershipRepository.UpdateMembership(membership);

                    if (!membershipSuccess)
                    {
                        throw new MembershipExceptions.MembershipRenewalException("There was an error in updating the membership!");
                    }

                    var payment = new PaymentHistory
                    {
                        Amount = membership.MembershipPrice,
                        PaymentDate = DateTime.Today,
                        PaymentType = "membership",
                        Membership_MembershipID = membership.MembershipID
                    };

                    var paymentSuccess = await _paymentRepository.AddPayment(payment);
                    if (!paymentSuccess)
                    {
                        throw new MembershipExceptions.PaymentHistoryException("Couldn't insert the payment!");
                    }

                    await transaction.CommitAsync();

                    await _context.SaveChangesAsync();
                    return Ok(membership);
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    return StatusCode(500, $"An unexpected error occurred: {ex.Message}");
                }
            }
        }

    }
}
