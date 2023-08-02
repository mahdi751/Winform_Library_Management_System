using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Models;
using LibraryAPI.Interfaces;
using LibraryAPI.DTOs;
using LibraryAPI.Exceptions;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BorrowController : ControllerBase
    {
        private readonly IBorrowRepository _borrowRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IMembershipRepository _membershipRepository;

        public BorrowController(IBorrowRepository borrowRepository, IBookRepository bookRepository, IMembershipRepository membershipRepository)
        {
            _borrowRepository = borrowRepository;
            _bookRepository = bookRepository;
            _membershipRepository = membershipRepository;
        }

        [HttpPost("BorrowBook")]
        public async Task<IActionResult> BorrowBook([FromBody] BorrowDTO borrowedBook)
        {
            try
            {
                var book = await _bookRepository.GetBookById(borrowedBook.Book_BookID);
                if(book == null)
                {
                    throw new BorrowExceptions.BorrowBookException("Invalid Book.");
                }

                if(book.Totalquantity <= 0)
                {
                    throw new BorrowExceptions.BorrowBookException("No more copies of the book available.");
                }

                var membership = await _membershipRepository.GetMembershipByMembershipID(borrowedBook.Membership_MembershipID);
                if(membership == null)
                {
                    throw new BorrowExceptions.BorrowBookException("Invalid Membership.Check the subscription!");
                }

                if (membership.RemainingBorrowAbility <= 0)
                    throw new BorrowExceptions.BorrowBookException("You have reached the borrow limit for your membership.");

                var Brbook = new Borrow
                {
                    Book_BookID = borrowedBook.Book_BookID,
                    Membership_MembershipID = borrowedBook.Membership_MembershipID,
                    PickupDate = DateTime.Today,
                    ReturnDate = DateTime.Today.AddDays(30),
                };

                if (await _borrowRepository.BorrowBook(Brbook))
                {
                    book.AvailableQuantity--;
                    if(!await _bookRepository.UpdateBook(book))
                    {
                        return BadRequest("Book AvailableQuantity was not updated!");
                    }

                    membership.RemainingBorrowAbility--;
                    if(!await _membershipRepository.UpdateMembership(membership))
                    {
                        return BadRequest("Membership RemainingBorrowAbility was not updated!");
                    }

                    return Ok("Book borrowed successfully!");
                }
                
                throw new BorrowExceptions.BorrowBookException("Failed to borrow the book.");

                
            }
            catch (BorrowExceptions.BorrowBookException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("CalculateAllOverdueFines")]
        public async Task<IActionResult> CalculateAllOverdueFines()
        {
            try
            {
                if (!await _borrowRepository.CalculateAllOverdueFines())
                    throw new BorrowExceptions.CalculateOverdueFinesException("Failed to calculate overdue fines.");

                return Ok("Overdue fines calculated and updated successfully.");
            }
            catch (BorrowExceptions.CalculateOverdueFinesException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetBorrowedBooks/{membershipID}")]
        public async Task<IActionResult> GetBorrowedBooks(int membershipID)
        {
            try
            {
                var borrowedBooks = await _borrowRepository.GetBorrowedBooks(membershipID);
                return Ok(borrowedBooks);
            }
            catch (BorrowExceptions.GetBorrowedBooksException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetBorrowedBooksByUser/{userid}")]
        public async Task<IActionResult> GetAllBorrowedBooksByUser(int userid)
        {
            try
            {
                var borrowedBooks = await _borrowRepository.GetBorrowedBooksByUser(userid);
                return Ok(borrowedBooks);
            }
            catch (BorrowExceptions.GetBorrowedBooksException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetUnReturnedBooks/{membershipID}")]
        public async Task<IActionResult> GetUnReturnedBooks(int membershipID)
        {
            try
            {
                var unReturnedBooks = await _borrowRepository.GetUnReturnedBooks(membershipID);
                return Ok(unReturnedBooks);
            }
            catch (BorrowExceptions.GetUnReturnedBooksException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetCurrentOverduePaymentsDetails/{membershipID}")]
        public async Task<IActionResult> GetCurrentOverduePaymentsDetails(int membershipID)
        {
            try
            {
                if (!await _borrowRepository.CalculateAllOverdueFines())
                    throw new BorrowExceptions.CalculateOverdueFinesException("Failed to calculate overdue fines.");

                var overduePayments = await _borrowRepository.GetOverduePaymentsDetails(membershipID);
                return Ok(overduePayments);
            }
            catch (BorrowExceptions.GetCurrentOverduePaymentsException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetCurrentOverduePayments/{membershipID}")]
        public async Task<IActionResult> GetCurrentOverduePayments(int membershipID)
        {
            try
            {
                if (!await _borrowRepository.CalculateAllOverdueFines())
                    throw new BorrowExceptions.CalculateOverdueFinesException("Failed to calculate overdue fines.");

                var overduePayments = await _borrowRepository.GetCurrentTotalOverduePayments(membershipID);
                return Ok(overduePayments);
            }
            catch (BorrowExceptions.GetCurrentOverduePaymentsException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetOverdueBooks/{membershipID}")]
        public async Task<IActionResult> GetOverdueBooks(int membershipID)
        {
            try
            {
                var overdueBooks = await _borrowRepository.GetOverdueBooks(membershipID);
                return Ok(overdueBooks);
            }
            catch (BorrowExceptions.GetOverdueBooksException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("ReturnBorrowedBook")]
        public async Task<IActionResult> ReturnBorrowedBook([FromBody] BorrowDTO borrowedBook)
        {
            try
            {
                var book = await _bookRepository.GetBookById(borrowedBook.Book_BookID);
                if (book == null)
                    throw new BorrowExceptions.ReturnBorrowedBookException("Invalid Book.");

                var borrowedRec = await _borrowRepository.GetBorrowedBookByMembershipID_BookID(borrowedBook.Membership_MembershipID, borrowedBook.Book_BookID);
                if (borrowedRec == null)
                    throw new BorrowExceptions.ReturnBorrowedBookException("The book is not borrowed by the member.");

                borrowedRec.ReturnedDate = DateTime.Now;
                borrowedRec.IsReturned = true;

                if (!await _borrowRepository.UpdateBorrowedBook(borrowedRec))
                    throw new BorrowExceptions.ReturnBorrowedBookException("Failed to update the borrowed book.");

                book.AvailableQuantity++;
                if (!await _bookRepository.UpdateBook(book))
                    throw new BorrowExceptions.ReturnBorrowedBookException("Failed to update the book quantity.");

                return Ok("Borrowed book returned successfully.");
            }
            catch (BorrowExceptions.ReturnBorrowedBookException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
