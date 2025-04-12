using Nestin.Core.Entities;

namespace Nestin.Core.Interfaces
{
    public interface ITokenService
    {
        public Task<string> CreateTokenAsync(AppUser user);
    }
}
