using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Http;
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

        [HttpGet("/Books")]
        [ProducesResponseType(200, Type = typeof(List<Book>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookRepository.GetAllBooks();
            if(books == null)
            {
                ModelState.AddModelError("", "There is no books!");
                return StatusCode(400, ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(books);
        }

        [HttpGet("/Books/BookTitle/{BookTilte}")]
        [ProducesResponseType(200, Type = typeof(List<Book>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetBookByTitle(string BookTilte)
        {
            var books = await _bookRepository.GetAllBooksByTitle(BookTilte);
            return Ok(books);
        }

        [HttpGet("/Books/AuthorName/{AuthorName}")]
        [ProducesResponseType(200, Type = typeof(List<Book>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetBookaByAuthorName(string AuthorName)
        {
            var books = await _bookRepository.GetAllBooksByAuthorName(AuthorName);
            return Ok(books);
        }

        [HttpGet("/Books/ISBN/{isbn}")]
        [ProducesResponseType(200, Type = typeof(List<Book>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetBookByIsbn(string isbn)
        {
            var book = await _bookRepository.GetBookByISBN(isbn);
            return Ok(book);
        }


    }
}
