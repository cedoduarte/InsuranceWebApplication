using InsuranceWebApplication.CQRS.Cars.ViewModel;
using MediatR;

namespace InsuranceWebApplication.CQRS.Cars.Query.GetCarList
{
    public class GetCarListQuery : IRequest<List<CarViewModel>>
    {
        public string? Keyword { get; set; }
        public bool GetAll { get; set; }
    }
}
