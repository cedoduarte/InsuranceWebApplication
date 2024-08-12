using InsuranceWebApplication.Interfaces;

namespace InsuranceWebApplication.Models
{
    public class User : ILastModified, ISoftDelete, ILastCreated
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public DateTime? LastModified { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
        public DateTime? LastDeleted { get; set; } = DateTime.UtcNow;
        public DateTime? LastCreated { get; set; } = DateTime.UtcNow;
    }
}
