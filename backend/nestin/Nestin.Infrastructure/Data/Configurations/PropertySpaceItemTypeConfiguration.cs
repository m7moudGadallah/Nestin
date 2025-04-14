using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Configurations
{
    class PropertySpaceItemTypeConfiguration : IEntityTypeConfiguration<PropertySpaceItemType>
    {
        public void Configure(EntityTypeBuilder<PropertySpaceItemType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(x => x.PropertySpaceType)
                .WithMany(x => x.PropertySpaceItemTypes)
                .HasForeignKey(x => x.PropertySpaceTypeId);
        }
    }
}
