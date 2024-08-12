using AutoMapper;
using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Insurances.Command.DeleteInsurance
{
    public class DeleteInsuranceHandler : IRequestHandler<DeleteInsuranceCommand, InsuranceViewModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteInsuranceHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<InsuranceViewModel> Handle(DeleteInsuranceCommand command, CancellationToken cancel)
        {
            Insurance? result = await _unitOfWork.InsuranceRepository.DeleteAsync(command.Id, cancel);
            return _mapper.Map<InsuranceViewModel>(result);
        }
    }
}
