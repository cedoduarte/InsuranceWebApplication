using InsuranceWebApplication.CQRS.Cars.Command.CreateCar;
using InsuranceWebApplication.CQRS.Cars.Command.DeleteCar;
using InsuranceWebApplication.CQRS.Cars.Command.UpdateCar;
using InsuranceWebApplication.CQRS.Cars.Query.GetCarById;
using InsuranceWebApplication.CQRS.Cars.Query.GetCarList;
using InsuranceWebApplication.CQRS.Cars.ViewModel;
using MediatR;

namespace InsuranceWebApplication.Services
{
    public interface ICarService
    {
        Task<CarViewModel?> CreateAsync(CreateCarCommand command);
        Task<CarViewModel?> UpdateAsync(UpdateCarCommand command);
        Task<CarViewModel?> DeleteAsync(int id);
        Task<CarViewModel?> GetByIdAsync(int id);
        Task<List<CarViewModel>> GetListAsync(GetCarListQuery query);
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

        public async Task<CarViewModel?> UpdateAsync(UpdateCarCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<CarViewModel?> DeleteAsync(int id)
        {
            return await _mediator.Send(new DeleteCarCommand()
            {
                Id = id
            });
        }

        public async Task<CarViewModel?> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetCarByIdQuery() 
            {
                Id = id
            });
        }

        public async Task<List<CarViewModel>> GetListAsync(GetCarListQuery query)
        {
            return await _mediator.Send(query);
        }
    }
}
