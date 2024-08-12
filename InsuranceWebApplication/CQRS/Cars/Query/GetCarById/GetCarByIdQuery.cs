using InsuranceWebApplication.CQRS.Cars.ViewModel;
using MediatR;

namespace InsuranceWebApplication.CQRS.Cars.Query.GetCarById
{
    public class GetCarByIdQuery : IRequest<CarViewModel>
    {
        public int Id { get; set; }
    }
}
