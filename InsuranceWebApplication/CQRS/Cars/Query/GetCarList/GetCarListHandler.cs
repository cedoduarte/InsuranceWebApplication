using AutoMapper;
using InsuranceWebApplication.CQRS.Cars.ViewModel;
using InsuranceWebApplication.Dtos;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Cars.Query.GetCarList
{
    public class GetCarListHandler : IRequestHandler<GetCarListQuery, CarListResultDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCarListHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CarListResultDto> Handle(GetCarListQuery query, CancellationToken cancel)
        {
            List<Car>? carList = null;
            var result = new CarListResultDto();

            result.TotalCount = await _unitOfWork.CarRepository.CountAsync(cancel);
            if (query.GetAll)
            {
                carList = await _unitOfWork.CarRepository.GetAllAsync(query.PageNumber, query.PageSize, cancel);
                result.CarList = _mapper.Map<List<CarViewModel>>(carList);
                return result;
            }

            if (string.IsNullOrEmpty(query.Keyword))
            {
                throw new Exception("The keyword is empty");
            }

            string keyword = query.Keyword.ToLower().Trim();
            carList = await _unitOfWork.CarRepository.GetByKeywordAsync(keyword, query.PageNumber, query.PageSize, cancel);
            result.CarList = _mapper.Map<List<CarViewModel>>(carList);
            return result;
        }
    }
}
