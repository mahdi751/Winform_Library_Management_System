using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using LibraryAPI.DTOs;
using LibraryAPI.Exceptions;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembershipController : ControllerBase
    {
        private readonly IMembershipRepository _membershipRepository;
        private readonly IPaymentRepository _paymentRepository;

        public MembershipController(IMembershipRepository membershipRepository, IPaymentRepository paymentRepository)
        {
            _membershipRepository = membershipRepository;
            _paymentRepository = paymentRepository;
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

                if (!membershipSuccess)
                {
                    throw new MembershipExceptions.MembershipCreationException("Failed to insert membership data.");
                }

                var payment = new PaymentHistory
                {
                    Amount = membership.MembershipPrice,
                    PaymentDate = DateTime.Today,
                    PaymentType = "membership",
                    User_UserID = membership.User_UserID
                };

                var paymentSuccess = await _paymentRepository.PayFines(payment);
                if(!paymentSuccess)
                {
                    throw new MembershipExceptions.PaymentHistoryException("Couldn't insert the payment!");
                }

                if(paymentSuccess && membershipSuccess)
                    return Ok(membership);
                else 
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An unexpected error occurred: {ex.Message}");
            }
        }


        [HttpPut("RenewCurrentMembership/{userid}")]
        public async Task<IActionResult> RenewMembership(int userid)
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
                    User_UserID = membership.User_UserID
                };

                var paymentSuccess = await _paymentRepository.PayFines(payment);
                if (!paymentSuccess)
                {
                    throw new MembershipExceptions.PaymentHistoryException("Couldn't insert the payment!");
                }

                return Ok(membership);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An unexpected error occurred: {ex.Message}");
            }
            
        }
    }

}
