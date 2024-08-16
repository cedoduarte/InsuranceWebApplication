using Microsoft.EntityFrameworkCore;

namespace InsuranceWebApplication.Models
{
    public interface IAppDbContext
    {
        DbSet<User>? Users { get; set; }
        DbSet<Car>? Cars { get; set; }
        DbSet<Insurance>? Insurances { get; set; }
        DbSet<VisitCount>? VisitCount { get; set; }
    }

    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Car>? Cars { get; set; }
        public DbSet<Insurance>? Insurances { get; set; }
        public DbSet<VisitCount>? VisitCount { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IAppDbContext).Assembly);
        }
    }
}
