using AutoMapper;
using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Insurances.Query.GetInsuranceList
{
    public class GetInsuranceListHandler : IRequestHandler<GetInsuranceListQuery, List<InsuranceViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetInsuranceListHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<InsuranceViewModel>> Handle(GetInsuranceListQuery query, CancellationToken cancel)
        {
            List<Insurance>? insuranceList = null;
            if (query.GetAll)
            {
                insuranceList = await _unitOfWork.InsuranceRepository.GetAllAsync(cancel);
                return _mapper.Map<List<InsuranceViewModel>>(insuranceList);
            }
            if (string.IsNullOrEmpty(query.Keyword))
            {
                throw new Exception("The keyword is empty");
            }
            string keyword = query.Keyword.ToLower().Trim();
            insuranceList = await _unitOfWork.InsuranceRepository.GetByKeywordAsync(keyword, cancel);
            return _mapper.Map<List<InsuranceViewModel>>(insuranceList);
        }
    }
}
