using InsuranceWebApplication.Interfaces;

namespace InsuranceWebApplication.Models
{
    public class Car : ILastModified, ISoftDelete, ILastCreated
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public decimal? Price { get; set; }
        public string? PlateNumber { get; set; }
        public DateTime? LastModified { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
        public DateTime? LastDeleted { get; set; } = DateTime.UtcNow;
        public DateTime? LastCreated { get; set; } = DateTime.UtcNow;
    }
}
