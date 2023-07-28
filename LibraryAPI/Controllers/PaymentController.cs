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

        public PaymentController(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        [HttpPost]
        public async Task<ActionResult> AddPayment([FromBody] PaymentHistory paymentHistory)
        {
            try
            {
                if (paymentHistory == null)
                    return BadRequest();

                await _paymentRepository.AddPayment(paymentHistory);
                return Ok(paymentHistory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet("/{userId}")]
        public async Task<ActionResult<ICollection<PaymentHistory>>> GetPaymentHistories(int userId)
        {
            var paymentHistories = await _paymentRepository.GetPaymentHistories(userId);
            return Ok(paymentHistories);
        }

        [HttpGet("/{userId}/{type}")]
        public async Task<ActionResult<ICollection<PaymentHistory>>> GetPaymentHistoriesByType(int userId, string type)
        {
            var paymentHistories = await _paymentRepository.GetPaymentHistoriesByType(userId, type);
            return Ok(paymentHistories);
        }

        [HttpGet("/totalAmount")]
        public async Task<ActionResult<decimal>> GetTotalPayments()
        {
            var totalPayments = await _paymentRepository.GetTotalPayments();
            return Ok(totalPayments);
        }
    }
}
