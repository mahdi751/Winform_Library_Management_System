using LibraryAPI.DTOs;
using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpPost("/login")]
        public async Task<ActionResult<User>> Login(LoginDTO loginDto)
        {
            var user = await _accountRepository.GetUserByUsername(loginDto.Username);
            if (user == null)
            {
                return Unauthorized("Invalid username");
            }

            using var hmac = new HMACSHA512(user.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i]) 
                    return Unauthorized("invalid password");
            }

            return Ok(user);


        }

        [HttpPost("/register")]
        [ProducesResponseType(200, Type = typeof(User))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Register([FromBody] RegisterDTO newUserDto)
        {
            if (newUserDto == null)
            {
                return BadRequest(ModelState);
            }

            if (await _accountRepository.UserExits(newUserDto.Username))
            {
                return BadRequest("Username is taken!");
            }

            if (await _accountRepository.EmailExists(newUserDto.Email))
            {
                return BadRequest("Email is taken!");
            }

            byte[] passwordSalt;
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
            }

            byte[] passwordHash;
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(newUserDto.Password));
            }

            var user = new User
            {
                Username = newUserDto.Username,
                Address = newUserDto.Address,
                FirstName = newUserDto.FirstName,
                LastName = newUserDto.LastName,
                Phone = newUserDto.Phone,
                Email = newUserDto.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            if (!await _accountRepository.AddUser(user))
            {
                ModelState.AddModelError("", "Process interrupted! Couldn't add user");
                return StatusCode(400, ModelState);
            }

            return Ok(user);
        }

        [HttpPost("/forgetPassword")]
        [ProducesResponseType(200, Type = typeof(User))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordDTO forgetPasswordDto)
        {
            if (forgetPasswordDto == null)
            {
                return BadRequest(ModelState);
            }

            var user = await _accountRepository.GetUserByUsername(forgetPasswordDto.Username);
            if (user == null)
            {
                return NotFound("User not found");
            }

            byte[] newPasswordHash;
            using (var hmac = new HMACSHA512(user.PasswordSalt))
            {
                newPasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(forgetPasswordDto.NewPassword));
            }

            user.PasswordHash = newPasswordHash;

            if(!await _accountRepository.UpdateUser(user))
            {
                ModelState.AddModelError("", "Process interrupted! Couldn't add user");
                return StatusCode(400, ModelState);
            }

            return Ok(user);
        }


    }
}
