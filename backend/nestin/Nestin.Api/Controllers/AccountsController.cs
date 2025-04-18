using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nestin.Api.Utils;
using Nestin.Core.Dtos.Accounts;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using System.Net.Mail;

namespace Nestin.Api.Controllers
{
    public class AccountsController : BaseController
    {
        private readonly IIdentityFactory _identityFactory;
        private readonly IServiceFactory _serviceFactory;

        public AccountsController(IUnitOfWork unitOfWork, IIdentityFactory identityFactory, IServiceFactory serviceFactory) : base(unitOfWork)
        {
            _identityFactory = identityFactory;
            _serviceFactory = serviceFactory;
        }

        [HttpPost("register")]
        [EndpointSummary("Register new user.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(NewUserDto), StatusCodes.Status201Created)]
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
                    var token = await _serviceFactory.TokenService.CreateTokenAsync(appUser);
                    _serviceFactory.TokenService.SetAccessTokenCookie(HttpContext, token);

                    return StatusCode(201, new NewUserDto
                    {
                        Id = appUser.Id,
                        UserName = appUser.UserName,
                        Token = token,
                    });
                }
                else
                {
                    return StatusCode(500, roleResult.ToErrorList());
                }
            }

            return StatusCode(500, createdUser.ToErrorList());
        }

        [HttpPost("login")]
        [EndpointSummary("Login user.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(NewUserDto), StatusCodes.Status201Created)]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            var userName = ExtractUsernameFromEmail(dto.Email);

            var user = await _identityFactory.UserManager.Users.FirstOrDefaultAsync(x => x.UserName == userName);

            if (user is not null)
            {
                var passCheckResult = await _identityFactory.SignInManager.CheckPasswordSignInAsync(user, dto.Password, false);

                if (passCheckResult.Succeeded)
                {
                    var token = await _serviceFactory.TokenService.CreateTokenAsync(user);
                    // Set secure HTTP-only cookie
                    _serviceFactory.TokenService.SetAccessTokenCookie(HttpContext, token);

                    return Ok(new NewUserDto
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        Token = token
                    });
                }
            }

            return Unauthorized("Invalid creditionals.");
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            _serviceFactory.TokenService.UnsetAccessTokenCookie(HttpContext);
            return Ok();
        }

        private string ExtractUsernameFromEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return email;
            return new MailAddress(email).User;
        }
    }
}
