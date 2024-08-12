using AutoMapper;
using InsuranceWebApplication.CQRS.Cars.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Cars.Command.DeleteCar
{
    public class DeleteCarHandler : IRequestHandler<DeleteCarCommand, CarViewModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteCarHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CarViewModel> Handle(DeleteCarCommand command, CancellationToken cancel)
        {
            Car? result = await _unitOfWork.CarRepository.DeleteAsync(command.Id, cancel);
            return _mapper.Map<CarViewModel>(result);
        }
    }
}
