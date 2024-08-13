using InsuranceWebApplication.CQRS.Cars.ViewModel;

namespace InsuranceWebApplication.Dtos
{
    public class CarListResultDto
    {
        public int TotalCount { get; set; }
        public List<CarViewModel>? CarList { get; set; }
    }
}
