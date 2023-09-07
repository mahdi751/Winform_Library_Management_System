using LibraryAPI.Exceptions;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpPost("CreateBook")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Book))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllBooks([FromBody] Book book)
        {
            try
            {
                var bookSuccess = await _bookRepository.AddBook(book);
                if(!bookSuccess)
                {
                    return BadRequest("Couldn't add the book!");
                }
                return Ok(book);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching books.", ex);
            }
        }

        [HttpGet("Books")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Book>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllBooks()
        {
            try
            {
                var books = await _bookRepository.GetAllBooks();
                return Ok(books);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching books.", ex);
            }
        }

        [HttpGet("GetBookRemainingQuantity/{bookid}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<int>> GetBookRemainingQuantity(int bookid)
        {
            try
            {
                var quantity = await _bookRepository.GetBookAvailableQuantity(bookid);
                return Ok(quantity);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching books.", ex);
            }
        }
            
        [HttpGet("Books/BookTitle/{bookTitle}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Book>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetBooksByTitle(string bookTitle)
        {
            try
            {
                var books = await _bookRepository.GetAllBooksByTitle(bookTitle);
                if (books == null)
                {
                    throw new BookExceptions.BooksByTitleNotFoundException("There are no books with that title!");
                }
                return Ok(books);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching books by title.", ex);
            }
        }

        [HttpGet("Books/BookGenre/{bookGenre}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Book>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetBooksByGenre(string bookGenre)
        {
            try
            {
                var books = await _bookRepository.GetAllBooksByGenre(bookGenre);
                if (books == null)
                {
                    throw new BookExceptions.BooksByGenreNotFoundException("There are no books with that genre!");
                }
                return Ok(books);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching books by genre.", ex);
            }
        }

        [HttpGet("Books/AuthorName/{authorName}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Book>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetBooksByAuthorName(string authorName)
        {
            try
            {
                var books = await _bookRepository.GetAllBooksByAuthorName(authorName);
                if (books == null)
                {
                    throw new BookExceptions.BooksByAuthorNameNotFoundException("There are no books with this Author Name");
                }
                return Ok(books);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching books by author name.", ex);
            }
        }

        [HttpGet("Books/ISBN/{isbn}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Book))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetBookByIsbn(string isbn)
        {
            try
            {
                var book = await _bookRepository.GetBookByISBN(isbn);
                if (book == null)
                {
                    throw new BookExceptions.BookByIsbnNotFoundException("No book found with the specified ISBN.");
                }
                return Ok(book);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the book by ISBN.", ex);
            }
        }
    }
}
