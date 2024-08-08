using InsuranceWebApplication.Enums;
using InsuranceWebApplication.Interfaces;

namespace InsuranceWebApplication.Models
{
    public class Insurance : ILastModified, ISoftDelete
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? TypeOfInsurance { get; set; }
        public decimal Premium { get; set; }
        public InsuranceStatus Status { get; set; }
        public DateTime? LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastDeleted { get; set; }

        public virtual User? User { get; set; }
        public virtual Car? Car { get; set; }
    }
}
