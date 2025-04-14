﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Configurations
{
    class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.CountryId)
                .IsRequired();

            builder.HasOne(x => x.Country)
                .WithMany(x => x.Locations)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
