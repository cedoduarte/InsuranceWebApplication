using AutoMapper;
using InsuranceWebApplication.CQRS.Cars.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Cars.Query.GetCarList
{
    public class GetCarListHandler : IRequestHandler<GetCarListQuery, List<CarViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCarListHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<CarViewModel>> Handle(GetCarListQuery query, CancellationToken cancel)
        {
            List<Car>? carList = null;
            if (query.GetAll)
            {
                carList = await _unitOfWork.CarRepository.GetAllAsync(cancel);
                return _mapper.Map<List<CarViewModel>>(carList);
            }
            if (string.IsNullOrEmpty(query.Keyword))
            {
                throw new Exception("The keyword is empty");
            }
            string keyword = query.Keyword.ToLower().Trim();
            carList = await _unitOfWork.CarRepository.GetByKeywordAsync(keyword, cancel);
            return _mapper.Map<List<CarViewModel>>(carList);
        }
    }
}
