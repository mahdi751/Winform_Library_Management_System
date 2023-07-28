using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using LibraryAPI.DTOs;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembershipController : ControllerBase
    {
        private readonly IMembershipRepository _membershipRepository;

        public MembershipController(IMembershipRepository membershipRepository)
        {
            _membershipRepository = membershipRepository;
        }

        [HttpGet("/Membership/userid/{userID}")]
        public async Task<IActionResult> GetMembershipByUserID(int userID)
        {
            var membership = await _membershipRepository.GetMembershipByUserID(userID);
            if (membership == null)
            {
                return NotFound();
            }
            return Ok(membership);
        }

        [HttpGet("/Membership/enddate/{membershipID}")]
        public async Task<IActionResult> GetMembershipEndDate(int membershipID)
        {
            var endDate = await _membershipRepository.GetMembershipEndDate(membershipID);
            if (endDate == default)
            {
                return NotFound();
            }
            return Ok(endDate);
        }

        [HttpGet("Membership/GetMembershipid/UserID/{userID}")]
        public async Task<IActionResult> GetMembershipIdByUserID(int userID)
        {
            var membershipId = await _membershipRepository.GetMembershipIdByUserID(userID);
            if (membershipId == 0)
            {
                return NotFound();
            }
            return Ok(membershipId);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddMembership([FromBody] MembershipDTO newMembershipDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(newMembershipDTO == null)
            {
                return BadRequest("enter data correctly");
            }

            var membership = new Membership
            {
                MembershipName = newMembershipDTO.MembershipName,
                MaxBorrowLimit = newMembershipDTO.MaxBorrowLimit,
                MembershipPrice = newMembershipDTO.MembershipPrice,
                RemainingBorrowAbility = newMembershipDTO.MaxBorrowLimit,
                User_UserID = newMembershipDTO.User_UserID
            };
          
            if(!await _membershipRepository.AddMembership(membership))
            {
                return BadRequest("Data not inserted!");
            }

            return Ok("Membership inserted!");
        }
    }
}
