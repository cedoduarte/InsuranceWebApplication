using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using MediatR;

namespace InsuranceWebApplication.CQRS.Insurances.Command.DeleteInsurance
{
    public class DeleteInsuranceCommand : IRequest<InsuranceViewModel>
    {
        public int Id { get; set; }
    }
}
