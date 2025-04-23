using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nestin.Core.Entities;
using Nestin.Infrastructure.Data.Seeds;

namespace Nestin.Infrastructure.Data.Configurations
{
    class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasMany(u => u.Roles)
                .WithMany()
                .UsingEntity<IdentityUserRole<string>>(
                    j => j.HasOne<IdentityRole>().WithMany().HasForeignKey(ur => ur.RoleId),
                    j => j.HasOne<AppUser>().WithMany().HasForeignKey(ur => ur.UserId));

            builder.HasData(AppUserSeed.Data);
        }
    }
}
