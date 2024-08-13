using InsuranceWebApplication.CQRS.Insurances.ViewModel;

namespace InsuranceWebApplication.Dtos
{
    public class InsuranceListResultDto
    {
        public int TotalCount { get; set; }
        public List<InsuranceViewModel>? InsuranceList { get; set; }
    }
}
