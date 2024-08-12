using AutoMapper;
using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Insurances.Query.GetInsuranceById
{
    public class GetInsuranceByIdHandler : IRequestHandler<GetInsuranceByIdQuery, InsuranceViewModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetInsuranceByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<InsuranceViewModel> Handle(GetInsuranceByIdQuery query, CancellationToken cancel)
        {
            Insurance? insurance = await _unitOfWork.InsuranceRepository.GetByIdAsync(query.Id, cancel);
            if (insurance is null)
            {
                throw new Exception($"The insurance with Id {query.Id} does not exist");
            }
            return _mapper.Map<InsuranceViewModel>(insurance);
        }
    }
}
