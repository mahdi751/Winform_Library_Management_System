using LibraryAPI.Exceptions;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
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

        [HttpPost("PayOverdueFine/{userid}/{overdueFine}")]
        public async Task<ActionResult> PayOverdueFine(int userid,int overdueFine)
        {
            
            try
            {
                var success = await _borrowRepository.UpdateOverdueFines(userid);
                if (!success)
                    return BadRequest("Couldn't complete the payment process!");

                var payment = new PaymentHistory
                {
                    Amount = overdueFine,
                    PaymentDate = DateTime.Today,
                    PaymentType = "overdue",
                    User_UserID = userid
                };

                var paymentSuccess = await _paymentRepository.PayFines(payment);
                if (!paymentSuccess)
                {
                    throw new MembershipExceptions.PaymentHistoryException("Couldn't insert the payment!");
                }

                return Ok(payment);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet("payments/{userId}")]
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
    }
}
