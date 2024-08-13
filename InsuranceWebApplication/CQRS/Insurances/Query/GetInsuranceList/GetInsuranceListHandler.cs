using AutoMapper;
using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using InsuranceWebApplication.Dtos;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Insurances.Query.GetInsuranceList
{
    public class GetInsuranceListHandler : IRequestHandler<GetInsuranceListQuery, InsuranceListResultDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetInsuranceListHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<InsuranceListResultDto> Handle(GetInsuranceListQuery query, CancellationToken cancel)
        {
            List<Insurance>? insuranceList = null;
            var result = new InsuranceListResultDto();

            result.TotalCount = await _unitOfWork.InsuranceRepository.CountAsync(cancel);
            if (query.GetAll)
            {
                insuranceList = await _unitOfWork.InsuranceRepository.GetAllAsync(query.PageNumber, query.PageSize, cancel);
                result.InsuranceList = _mapper.Map<List<InsuranceViewModel>>(insuranceList);
                return result;
            }

            if (string.IsNullOrEmpty(query.Keyword))
            {
                throw new Exception("The keyword is empty");
            }

            string keyword = query.Keyword.ToLower().Trim();
            insuranceList = await _unitOfWork.InsuranceRepository.GetByKeywordAsync(keyword, query.PageNumber, query.PageSize, cancel);
            result.InsuranceList = _mapper.Map<List<InsuranceViewModel>>(insuranceList);
            return result;
        }
    }
}
