using Microsoft.AspNetCore.Identity;
using Nestin.Core.Entities;

namespace Nestin.Core.Interfaces
{
    public interface IIdentityFactory
    {
        public UserManager<AppUser> UserManager { get; }
        public RoleManager<IdentityRole> RoleManager { get; }
        public SignInManager<AppUser> SignInManager { get; }
    }
}
