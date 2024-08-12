using AutoMapper;
using InsuranceWebApplication.CQRS.Cars.Validators;
using InsuranceWebApplication.CQRS.Cars.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;
using System.Text;

namespace InsuranceWebApplication.CQRS.Cars.Command.CreateCar
{
    public class CreateCarHandler : IRequestHandler<CreateCarCommand, CarViewModel>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        private readonly ICreateCarCommandValidator _validator;

        public CreateCarHandler(
            ICarRepository carRepository,
            IMapper mapper,
            ICreateCarCommandValidator validator)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<CarViewModel> Handle(CreateCarCommand command, CancellationToken cancel)
        {
            _validator.Validate(command);
            if (_validator.Errors.Any())
            {
                StringBuilder builder = new StringBuilder();
                foreach (string error in _validator.Errors)
                {
                    builder.AppendLine(error);
                }
                throw new Exception(builder.ToString());
            }
            Car car = new Car()
            {
                Model = command.Model!.Trim(),
                Color = command.Color!.Trim(),
                Price = command.Price!,
                PlateNumber = command.PlateNumber!.Trim()
            };
            Car? result = await _carRepository.CreateAsync(car, cancel);
            if (result is null)
            {
                throw new Exception("Error creating a new car");
            }
            return _mapper.Map<CarViewModel>(result);
        }
    }
}
