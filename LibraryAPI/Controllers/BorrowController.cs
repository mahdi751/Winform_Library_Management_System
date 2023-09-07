using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Models;
using LibraryAPI.Interfaces;
using LibraryAPI.DTOs;
using LibraryAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using LibraryAPI.Data;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BorrowController : ControllerBase
    {
        private readonly IBorrowRepository _borrowRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IMembershipRepository _membershipRepository;
        private readonly DataContext _context;

        public BorrowController(IBorrowRepository borrowRepository, IBookRepository bookRepository, IMembershipRepository membershipRepository, DataContext context)
        {
            _borrowRepository = borrowRepository;
            _bookRepository = bookRepository;
            _membershipRepository = membershipRepository;

            _context = context;
        }

        [HttpPost("BorrowBook")]
        public async Task<ActionResult<bool>> BorrowBook([FromBody] BorrowDTO borrowedBook)
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

                    await _membershipRepository.Save();

                    return Ok(true);
                }
                else
                    return false;
            }
            catch (BorrowExceptions.BorrowBookException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateBorrowBookRecord")]
        public async Task<ActionResult<bool>> UpdateBorrowBookRecord([FromBody] BorrowDTO borrowedBook)
        {
            try
            {
                var book = await _bookRepository.GetBookById(borrowedBook.Book_BookID);
                if (book == null)
                {
                    throw new BorrowExceptions.BorrowBookException("Invalid Book.");
                }

                if (book.Totalquantity <= 0)
                {
                    throw new BorrowExceptions.BorrowBookException("No more copies of the book available.");
                }

                var membership = await _membershipRepository.GetMembershipByMembershipID(borrowedBook.Membership_MembershipID);
                if (membership == null)
                {
                    throw new BorrowExceptions.BorrowBookException("Invalid Membership.Check the subscription!");
                }

                if (membership.RemainingBorrowAbility <= 0)
                    throw new BorrowExceptions.BorrowBookException("You have reached the borrow limit for your membership.");

                var borrowRec = await _borrowRepository.GetBorrowRecordByMembership(borrowedBook.Book_BookID, borrowedBook.Membership_MembershipID);
                if (borrowRec != null)
                {
                    borrowRec.PickupDate = DateTime.Today;
                    borrowRec.ReturnDate = DateTime.Today.AddDays(30);
                    borrowRec.IsReturned = false;

                    if (await _borrowRepository.UpdateBorrowedBook(borrowRec))
                    {
                        book.AvailableQuantity--;
                        if (!await _bookRepository.UpdateBook(book))
                        {
                            return BadRequest("Book AvailableQuantity was not updated!");
                        }

                        membership.RemainingBorrowAbility--;
                        if (!await _membershipRepository.UpdateMembership(membership))
                        {
                            return BadRequest("Membership RemainingBorrowAbility was not updated!");
                        }

                        await _membershipRepository.Save();

                        return Ok(true);
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (BorrowExceptions.BorrowBookException ex)
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

        [HttpGet("GetReturnedBooks/{membershipID}")]
        public async Task<IActionResult> GetReturnedBooks(int membershipID)
        {
            try
            {
                var ReturnedBooks = await _borrowRepository.GetReturnedBooks(membershipID);
                return Ok(ReturnedBooks);
            }
            catch (BorrowExceptions.GetUnReturnedBooksException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetBookBorrowRecords/{bookid}/{userid}")]
        public async Task<ActionResult<IEnumerable<Borrow>>> GetBookBorrowRecords(int bookid, int userid)
        {
            var borrowRec = await _borrowRepository.GetBookBorrowRecords(bookid,userid);
            return Ok(borrowRec);
        }

        [HttpGet("GetBorrowRecordByMembership/{bookid}/{membershipID}")]
        public async Task<ActionResult<Borrow>> GetBorrowRecordByMembership(int bookid, int membershipID)
        {
            var borrowRec = await _borrowRepository.GetBorrowRecordByMembership(bookid, membershipID);
           
            if (borrowRec == null)
            {
                return NotFound();
            }

            return Ok(borrowRec);
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
        public async Task<ActionResult<bool>> ReturnBorrowedBook([FromBody] BorrowDTO borrowedBook)
        {
            using (var transaction = _context.Database.BeginTransaction())
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

                    transaction.Commit();
                    await _context.SaveChangesAsync();

                    return Ok(true);
                }
                catch (BorrowExceptions.ReturnBorrowedBookException ex)
                {
                    transaction.Rollback();
                    return BadRequest(ex.Message);
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred.");
                }
            }
        }

    }
}
