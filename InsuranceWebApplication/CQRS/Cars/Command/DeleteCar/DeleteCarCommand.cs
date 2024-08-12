using InsuranceWebApplication.CQRS.Cars.ViewModel;
using MediatR;

namespace InsuranceWebApplication.CQRS.Cars.Command.DeleteCar
{
    public class DeleteCarCommand : IRequest<CarViewModel>
    {
        public int Id { get; set; }
    }
}
