using AutoMapper;
using InsuranceWebApplication.CQRS.Cars.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Cars.Command.DeleteCar
{
    public class DeleteCarHandler : IRequestHandler<DeleteCarCommand, CarViewModel>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public DeleteCarHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<CarViewModel> Handle(DeleteCarCommand command, CancellationToken cancel)
        {
            Car? result = await _carRepository.DeleteAsync(command.Id, cancel);
            return _mapper.Map<CarViewModel>(result);
        }
    }
}
