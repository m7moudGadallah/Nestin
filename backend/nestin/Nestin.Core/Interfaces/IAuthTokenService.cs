using Microsoft.AspNetCore.Http;
using Nestin.Core.Entities;

namespace Nestin.Core.Interfaces
{
    public interface IAuthTokenService
    {
        public void SetAccessTokenCookie(HttpContext ctx, string token);
        public void UnsetAccessTokenCookie(HttpContext ctx);
        public Task<string> CreateTokenAsync(AppUser user);
    }
}
