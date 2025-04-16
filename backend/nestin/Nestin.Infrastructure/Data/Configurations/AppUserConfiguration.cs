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
            builder.HasData(AppUserSeed.Data);
        }
    }
}
