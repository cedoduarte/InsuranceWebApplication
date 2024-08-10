using InsuranceWebApplication.CQRS.Cars.Command.CreateCar;
using InsuranceWebApplication.CQRS.Cars.ViewModel;
using MediatR;

namespace InsuranceWebApplication.Services
{
    public interface ICarService
    {
        Task<CarViewModel?> CreateAsync(CreateCarCommand command);
    }

    public class CarService : ICarService
    {
        private readonly IMediator _mediator;

        public CarService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<CarViewModel?> CreateAsync(CreateCarCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
