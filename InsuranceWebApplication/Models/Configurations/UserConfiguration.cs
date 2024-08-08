using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsuranceWebApplication.Models.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FirstName).IsRequired().HasColumnType("NVARCHAR(256)");
            builder.Property(u => u.LastName).IsRequired().HasColumnType("NVARCHAR(256)");
            builder.Property(u => u.Email).IsRequired().HasColumnType("NVARCHAR(254)");
            builder.Property(u => u.PasswordHash).IsRequired().HasColumnType("NVARCHAR(256)");
            builder.Property(u => u.LastModified).IsRequired().HasColumnType("DATETIME2");
            builder.Property(u => u.IsDeleted).IsRequired().HasColumnType("BIT");
            builder.Property(u => u.LastDeleted).IsRequired().HasColumnType("DATETIME2");
        }
    }
}
