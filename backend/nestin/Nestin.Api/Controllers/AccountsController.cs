using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.Accounts;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using System.Net.Mail;

namespace Nestin.Api.Controllers
{
    public class AccountsController : BaseController
    {
        private readonly IIdentityFactory _identityFactory;

        public AccountsController(IUnitOfWork unitOfWork, IIdentityFactory identityFactory) : base(unitOfWork)
        {
            _identityFactory = identityFactory;
        }

        [HttpPost("register")]
        [EndpointSummary("Register new user.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> Register([FromBody] RegisterDto dto)
        {
            var username = ExtractUsernameFromEmail(dto.Email);

            var appUser = new AppUser
            {
                UserName = username,
                Email = dto.Email,
            };

            var createdUser = await _identityFactory.UserManager.CreateAsync(appUser, dto.Password);

            if (createdUser.Succeeded)
            {
                var roleResult = await _identityFactory.UserManager.AddToRoleAsync(appUser, "Guest");

                if (roleResult.Succeeded)
                {
                    return Ok("User Created");
                }
                else
                {
                    return StatusCode(500, roleResult.Errors);
                }
            }

            return StatusCode(500, createdUser.Errors);
        }

        [HttpPost("login")]
        [EndpointSummary("Login user.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            throw new NotImplementedException();
        }

        private string ExtractUsernameFromEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return email;
            return new MailAddress(email).User;
        }
    }
}
