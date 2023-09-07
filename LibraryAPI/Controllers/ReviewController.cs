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

        [HttpPost("Create")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<Review>> ReviewBook([FromBody] ReviewDTO reviewDto)
        {
            var bookReview = new Review
            {
                Book_BookID = reviewDto.BookID,
                Membership_MembershipID = reviewDto.MembershipID,
                Comment = reviewDto.Comment,
                Rating = reviewDto.Rating,
                ReviewDate = DateTime.Today
            };

            if(!await _reviewRepository.AddReview(bookReview))
            {
                return BadRequest("Error while adding review");
            }
            
            return Ok(bookReview);
        }

        [HttpGet("Reviews/{bookId}")]
        [ProducesResponseType(200, Type = typeof(List<Review>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetAllReviewsForBook(int bookId)
        {
            try
            {
                var reviews = await _reviewRepository.GetAllReviewsOfaBook(bookId);
                return Ok(reviews);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("getReview/{bookID}/{userid}")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetReview(int bookID, int userid)
        {
            var review = await _reviewRepository.GetReviewByBookID_UserID(bookID, userid);
            return Ok(review);
        }

        [HttpGet("GetBookAverageRating/{bookID}")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetBookAverageRating(int bookID)
        {
            var rating = await _reviewRepository.GetBookAverageRating(bookID);
            return Ok(rating);
        }

        [HttpPut("changeReview/{bookID}/{userid}")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> ChangeReview(int bookID, int userid,ReviewDTO reviewDTO)
        {
            var review = await _reviewRepository.GetReviewByBookID_UserID(bookID, userid);
            if(review == null)
            {
                return BadRequest("Couldn't retreive your review!");
            }

            review.ReviewDate = DateTime.Today;
            review.Rating = reviewDTO.Rating;
            review.Comment = reviewDTO.Comment;

            if(!await _reviewRepository.UpdateReview(review))
            {
                return BadRequest("Something went wrong while updating your review!");
            }

            return Ok(review);
        }


    }
}
