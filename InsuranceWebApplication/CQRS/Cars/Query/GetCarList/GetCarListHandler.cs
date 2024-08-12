using AutoMapper;
using InsuranceWebApplication.CQRS.Cars.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Cars.Query.GetCarList
{
    public class GetCarListHandler : IRequestHandler<GetCarListQuery, List<CarViewModel>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetCarListHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<List<CarViewModel>> Handle(GetCarListQuery query, CancellationToken cancel)
        {
            List<Car>? carList = null;
            if (query.GetAll)
            {
                carList = await _carRepository.GetAllAsync(cancel);
                return _mapper.Map<List<CarViewModel>>(carList);
            }
            if (string.IsNullOrEmpty(query.Keyword))
            {
                throw new Exception("The keyword is empty");
            }
            string keyword = query.Keyword.ToLower().Trim();
            carList = await _carRepository.GetByKeywordAsync(keyword);
            return _mapper.Map<List<CarViewModel>>(carList);
        }
    }
}
