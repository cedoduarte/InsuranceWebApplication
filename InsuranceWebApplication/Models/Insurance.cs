using InsuranceWebApplication.Enums;
using InsuranceWebApplication.Interfaces;

namespace InsuranceWebApplication.Models
{
    public class Insurance : ILastModified, ISoftDelete, ILastCreated
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? TypeOfInsurance { get; set; }
        public decimal Premium { get; set; }
        public InsuranceStatus Status { get; set; }
        public DateTime? LastModified { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
        public DateTime? LastDeleted { get; set; } = DateTime.UtcNow;
        public DateTime? LastCreated { get; set; } = DateTime.UtcNow;

        public virtual User? User { get; set; }
        public virtual Car? Car { get; set; }
    }
}
