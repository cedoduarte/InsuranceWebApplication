using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using InsuranceWebApplication.Enums;
using MediatR;

namespace InsuranceWebApplication.CQRS.Insurances.Command.UpdateInsurance
{
    public class UpdateInsuranceCommand : IRequest<InsuranceViewModel>
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? CarId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? TypeOfInsurance { get; set; }
        public decimal? Premium { get; set; }
        public InsuranceStatus? Status { get; set; }
    }
}
