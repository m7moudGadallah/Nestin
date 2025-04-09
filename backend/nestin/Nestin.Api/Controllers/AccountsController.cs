using Microsoft.AspNetCore.Mvc;
using Nestin.Core.Dtos.Accounts;
using Nestin.Core.Interfaces;

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
        public Task<IActionResult> Register([FromBody] RegisterDto dto)
        {
            throw new NotImplementedException();
        }

        [HttpPost("login")]
        [EndpointSummary("Login user.")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
