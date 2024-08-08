using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsuranceWebApplication.Models.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c => c.Model).IsRequired().HasColumnType("NVARCHAR(256)");
            builder.Property(c => c.Color).IsRequired().HasColumnType("NVARCHAR(256)");
            builder.Property(c => c.Price).IsRequired().HasColumnType("DECIMAL(18,2)");
            builder.Property(c => c.PlateNumber).IsRequired().HasColumnType("NVARCHAR(256)");
            builder.Property(c => c.LastModified).IsRequired().HasColumnType("DATETIME2");
            builder.Property(c => c.IsDeleted).IsRequired().HasColumnType("BIT");
            builder.Property(c => c.LastDeleted).IsRequired().HasColumnType("DATETIME2");
        }
    }
}
