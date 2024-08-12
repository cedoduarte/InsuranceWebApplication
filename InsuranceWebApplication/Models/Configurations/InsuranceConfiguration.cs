using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsuranceWebApplication.Models.Configurations
{
    public class InsuranceConfiguration : IEntityTypeConfiguration<Insurance>
    {
        public void Configure(EntityTypeBuilder<Insurance> builder)
        {
            builder.Property(i => i.UserId).IsRequired().HasColumnType("INT");
            builder.Property(i => i.CarId).IsRequired().HasColumnType("INT");
            builder.Property(i => i.StartDate).IsRequired().HasColumnType("DATETIME2");
            builder.Property(i => i.EndDate).IsRequired().HasColumnType("DATETIME2");
            builder.Property(i => i.TypeOfInsurance).IsRequired().HasColumnType("NVARCHAR(256)");
            builder.Property(i => i.Premium).IsRequired().HasColumnType("DECIMAL(18, 2)");
            builder.Property(i => i.Status).IsRequired().HasColumnType("INT");
            builder.Property(i => i.LastModified).IsRequired().HasColumnType("DATETIME2");
            builder.Property(i => i.IsDeleted).IsRequired().HasColumnType("BIT");
            builder.Property(i => i.LastDeleted).IsRequired().HasColumnType("DATETIME2");
            builder.Property(i => i.LastCreated).IsRequired().HasColumnType("DATETIME2");
        }
    }
}
