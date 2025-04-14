using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Configurations
{
    class FileUploadConfiguration : IEntityTypeConfiguration<FileUpload>
    {
        public void Configure(EntityTypeBuilder<FileUpload> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");

            builder.Property(x => x.Path)
                .IsRequired()
                .HasMaxLength(300);
        }
    }
}
