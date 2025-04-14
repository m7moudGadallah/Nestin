using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nestin.Core.Entities;
using System.Reflection;

namespace Nestin.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<GuestType> GuestTypes { get; set; }
        public virtual DbSet<AmenityCategory> AmenityCategories { get; set; }
        public virtual DbSet<Amenity> Amenities { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<PropertySpaceType> PropertySpaceTypes { get; set; }
        public virtual DbSet<PropertySpaceItemType> PropertySpaceItemTypes { get; set; }
        public virtual DbSet<FileUpload> FileUploads { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyPhoto> PropertyPhotos { get; set; }
    }
}