using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;

namespace Nestin.Infrastructure.Shared
{
    public class IdentityFactory : IIdentityFactory
    {
        private readonly IServiceProvider _provider;
        private UserManager<AppUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public IdentityFactory(IServiceProvider provider)
        {
            _provider = provider;
        }

        public UserManager<AppUser> UserManager => _userManager ??= _provider.GetRequiredService<UserManager<AppUser>>();

        public RoleManager<IdentityRole> RoleManager => _roleManager ??= _provider.GetRequiredService<RoleManager<IdentityRole>>();
    }
}
