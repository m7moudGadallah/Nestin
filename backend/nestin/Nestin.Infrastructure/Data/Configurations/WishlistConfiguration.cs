using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nestin.Core.Entities;
using Nestin.Infrastructure.Data.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestin.Infrastructure.Data.Configurations
{
    public class WishlistConfiguration : IEntityTypeConfiguration<Wishlist>
    {
        public void Configure(EntityTypeBuilder<Wishlist> builder)
        {
            builder.HasKey(x => new { x.PropertyId, x.GuestId });
            builder.Property(x => x.PropertyId)
                .IsRequired();
            builder.Property(x => x.GuestId)
                .IsRequired();

            builder.HasOne(x => x.Property)
                .WithMany()
                .HasForeignKey(x=>x.PropertyId)
            .OnDelete(DeleteBehavior.Restrict);



            builder.HasOne(x => x.Guest)
               .WithMany()
               .HasForeignKey(x => x.GuestId)
               .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(WishlistSeed.Data);

        }
    }
}
