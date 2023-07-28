using LibraryAPI.DTOs;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using LibraryAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewController(IReviewRepository reviewRepository) 
        {
            _reviewRepository = reviewRepository;
        }

        [HttpPost("/review/{bookID}/{membershipID}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> ReviewBook(int bookID,int membershipID, [FromBody] ReviewDTO reviewDto)
        {
            if (reviewDto == null)
            {
                return BadRequest("Invalid review data");
            }

            var bookReview = new Review
            {
                Book_BookID = bookID,
                Membership_MembershipID = membershipID,
                Comment = reviewDto.Comment,
                Rating = reviewDto.Rating,
            };

            if(!await _reviewRepository.AddReview(bookReview))
            {
                return BadRequest("Error while adding review");
            }
            
            return Ok("Book review added");
        }

        [HttpGet("/review/GetReview/{bookId}")]
        [ProducesResponseType(200, Type = typeof(List<Review>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetAllReviewsForBook(int bookId)
        {
            var reviews = await _reviewRepository.GetAllReviewsOfaBook(bookId);
            
            if(reviews == null)
            {
                return Ok("No reviews found");
            }
            return Ok(reviews);
        }


    }
}
