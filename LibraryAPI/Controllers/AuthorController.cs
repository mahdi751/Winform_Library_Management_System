using LibraryAPI.Exceptions;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet("{bookid}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetBooksByGenre(int bookid)
        {
            try
            {
                var author = await _authorRepository.GetAuthorByBookID(bookid);

                return Ok(author);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching authors.", ex);
            }
        }
    }
}
