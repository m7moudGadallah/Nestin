﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Configurations
{
    class AmenityConfiguration : IEntityTypeConfiguration<Amenity>
    {
        public void Configure(EntityTypeBuilder<Amenity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Icon)
                .IsRequired(false);

            builder.Property(x => x.CategoryId)
                .IsRequired();

            builder.HasOne(x => x.AmenityCategory)
                .WithMany(x => x.Amenities)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
