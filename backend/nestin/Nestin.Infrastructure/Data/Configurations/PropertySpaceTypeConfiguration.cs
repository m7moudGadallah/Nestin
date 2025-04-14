using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Configurations
{
    class PropertySpaceTypeConfiguration : IEntityTypeConfiguration<PropertySpaceType>
    {
        public void Configure(EntityTypeBuilder<PropertySpaceType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
