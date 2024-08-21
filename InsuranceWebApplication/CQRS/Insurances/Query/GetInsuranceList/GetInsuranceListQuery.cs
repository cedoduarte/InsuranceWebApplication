using InsuranceWebApplication.Dtos;
using MediatR;

namespace InsuranceWebApplication.CQRS.Insurances.Query.GetInsuranceList
{
    public class GetInsuranceListQuery : IRequest<InsuranceListResultDto>
    {
        public string? Keyword { get; set; }
        public bool GetAll { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public bool ResetCache { get; set; }
    }
}
