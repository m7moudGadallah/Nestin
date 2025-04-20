using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nestin.Infrastructure.Data.Seeds;

namespace Nestin.Infrastructure.Data.Configurations
{
    public class PropertyAvailabilityConfiguration : IEntityTypeConfiguration<Core.Entities.PropertyAvailability>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.PropertyAvailability> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.StartDate).
                IsRequired()
                .HasColumnType("datetime2(3)");



            builder.Property(x => x.EndDate)
            .IsRequired()
            .HasColumnType("datetime2(3)");

            builder.Property(x => x.IsAvailable)
                    .HasDefaultValue(true);

            builder.Property(x => x.PropertyId)
                .IsRequired();

            builder.HasOne(x => x.Property)
                .WithMany(x => x.PropertyAvailabilities)
                .HasForeignKey(x => x.PropertyId);



            builder.HasData(PropertyAvailabilitySeed.Data);
        }
    }
}

