using InsuranceWebApplication.Enums;

namespace InsuranceWebApplication.CQRS.Insurances.ViewModel
{
    public class InsuranceViewModel
    {
        public int Id { get; set; }        
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? TypeOfInsurance { get; set; }
        public decimal? Premium { get; set; }
        public InsuranceStatus? Status { get; set; }
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int CarId { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public decimal? Price { get; set; }
        public string? PlateNumber { get; set; }
        public DateTime? LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastDeleted { get; set; }
        public DateTime? LastCreated { get; set; }
    }
}
