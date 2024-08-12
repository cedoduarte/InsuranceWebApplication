using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using MediatR;

namespace InsuranceWebApplication.CQRS.Insurances.Query.GetInsuranceById
{
    public class GetInsuranceByIdQuery : IRequest<InsuranceViewModel>
    {
        public int Id { get; set; }
    }
}
