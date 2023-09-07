using LibraryAPI.DTOs;
using LibraryAPI.Exceptions;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using LibraryAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IBorrowRepository _borrowRepository;

        public PaymentController(IPaymentRepository paymentRepository, IBorrowRepository borrowRepository)
        {
            _paymentRepository = paymentRepository;
            _borrowRepository = borrowRepository;
        }

        [HttpPost("PayAllOverdueFine")]
        public async Task<IActionResult> PayAllOverdueFines([FromBody] PaymentDTO paymentDTO)
        {
            try
            {
                var success = await _paymentRepository.UpdateOverdueFines(paymentDTO.MembershipID);
                if (!success)
                    return BadRequest("Couldn't complete the payment process!");

                var payment = new PaymentHistory
                {
                    Amount = (double)paymentDTO.Fine,
                    PaymentDate = DateTime.Today,
                    PaymentType = "overdue",
                    Membership_MembershipID = paymentDTO.MembershipID
                };

                await _paymentRepository.AddPayment(payment);

                if(await _paymentRepository.Save())
                    return Ok(payment);
                else
                    throw new MembershipExceptions.PaymentHistoryException("Couldn't insert the payment!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPost("PayBookFines")]
        public async Task<IActionResult> PayBookFines([FromBody] PaymentDTO paymentDTO)
        {
            try
            {
                var success = await _paymentRepository.PayBookFines(paymentDTO.BookID, paymentDTO.MembershipID);
                if (!success)
                    return BadRequest("Couldn't complete the payment process!");

                var payment = new PaymentHistory
                {
                    Amount = (double)paymentDTO.Fine,
                    PaymentDate = DateTime.Today,
                    PaymentType = "overdue",
                    Membership_MembershipID = paymentDTO.MembershipID
                };

                await _paymentRepository.AddPayment(payment);

                if (await _paymentRepository.Save())
                    return Ok(payment);
                else
                    throw new MembershipExceptions.PaymentHistoryException("Couldn't insert the payment!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet("Payments/{userId}")]
        public async Task<ActionResult<ICollection<PaymentHistory>>> GetPaymentHistories(int userId)
        {
            try
            {
                var paymentHistories = await _paymentRepository.GetPaymentHistories(userId);
                return Ok(paymentHistories);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet("payments/{userId}/{type}")]
        public async Task<ActionResult<ICollection<PaymentHistory>>> GetPaymentHistoriesByType(int userId, string type)
        {
            try
            {
                var paymentHistories = await _paymentRepository.GetPaymentHistoriesByType(userId, type);
                return Ok(paymentHistories);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet("totalAmount")]
        public async Task<ActionResult<decimal>> GetTotalPayments()
        {
            try
            {
                var totalPayments = await _paymentRepository.GetTotalPayments();
                return Ok(totalPayments);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet("GetCurrentTotalOverduePayments/{membershipID}")]
        public async Task<IActionResult> GetCurrentTotalOverduePayments(int membershipID)
        {
            try
            {
                if (!await _paymentRepository.CalculateOverdueFinesByMembershipID(membershipID))
                    throw new BorrowExceptions.CalculateOverdueFinesException("Failed to calculate overdue fines.");

                var overduePayments = await _paymentRepository.GetCurrentTotalOverduePayments(membershipID);
                return Ok(overduePayments);
            }
            catch (BorrowExceptions.GetCurrentOverduePaymentsException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("GetCurrentOverduePaymentsDetails/{membershipID}")]
        public async Task<ActionResult<int>> GetCurrentOverduePaymentsDetails(int membershipID)
        {
            try
            {
                if (!await _paymentRepository.CalculateOverdueFinesByMembershipID(membershipID))
                    throw new BorrowExceptions.CalculateOverdueFinesException("Failed to calculate overdue fines.");

                var overduePayments = await _paymentRepository.GetOverduePaymentsDetails(membershipID);
                return Ok(overduePayments);
            }
            catch (BorrowExceptions.GetCurrentOverduePaymentsException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetBookFines/{bookID}/{membershipID}")]
        public async Task<ActionResult<int>> GetBookFines(int bookID, int membershipID)
        {
            try
            {
                if (!await _paymentRepository.CalculateOverdueFinesByMembershipID(membershipID))
                    throw new BorrowExceptions.CalculateOverdueFinesException("Failed to calculate overdue fines.");

                int bookFines = await _paymentRepository.GetOverdueFineByBookID(bookID, membershipID);
                return bookFines;
            }
            catch (BorrowExceptions.GetCurrentOverduePaymentsException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
