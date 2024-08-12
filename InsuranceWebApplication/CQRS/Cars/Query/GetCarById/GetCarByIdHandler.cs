using AutoMapper;
using InsuranceWebApplication.CQRS.Cars.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Cars.Query.GetCarById
{
    public class GetCarByIdHandler : IRequestHandler<GetCarByIdQuery, CarViewModel>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetCarByIdHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<CarViewModel> Handle(GetCarByIdQuery query, CancellationToken cancel)
        {
            Car? car = await _carRepository.GetByIdAsync(query.Id, cancel);
            if (car is null)
            {
                throw new Exception($"The car with Id {query.Id} does not exist");
            }
            return _mapper.Map<CarViewModel>(car);
        }
    }
}
