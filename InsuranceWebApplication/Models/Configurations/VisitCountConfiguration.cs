using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsuranceWebApplication.Models.Configurations
{
    public class VisitCountConfiguration : IEntityTypeConfiguration<VisitCount>
    {
        public void Configure(EntityTypeBuilder<VisitCount> builder)
        {
            builder.Property(v => v.Count).IsRequired().HasColumnType("INT");
        }
    }
}
