using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using MediatR;

namespace InsuranceWebApplication.CQRS.Insurances.Query.GetInsuranceList
{
    public class GetInsuranceListQuery : IRequest<List<InsuranceViewModel>>
    {
        public string? Keyword { get; set; }
        public bool GetAll { get; set; }
    }
}
