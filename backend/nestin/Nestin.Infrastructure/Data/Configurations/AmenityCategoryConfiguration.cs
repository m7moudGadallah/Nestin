using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nestin.Core.Entities;
using Nestin.Infrastructure.Data.Seeds;

namespace Nestin.Infrastructure.Data.Configurations
{
    class AmenityCategoryConfiguration : IEntityTypeConfiguration<AmenityCategory>
    {
        public void Configure(EntityTypeBuilder<AmenityCategory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasData(AmenityCategorySeed.Data);
        }
    }
}
