using AutoMapper;
using InsuranceWebApplication.CQRS.Insurances.Validators;
using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;
using System.Text;

namespace InsuranceWebApplication.CQRS.Insurances.Command.CreateInsurance
{
    public class CreateInsuranceHandler : IRequestHandler<CreateInsuranceCommand, InsuranceViewModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICreateInsuranceCommandValidator _validator;

        public CreateInsuranceHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            ICreateInsuranceCommandValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }

        private async Task ValidateInput(CreateInsuranceCommand command, CancellationToken cancel)
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
            bool userExist = await _unitOfWork.UserRepository.ExistAsync((int)command.UserId!, cancel);
            if (!userExist)
            {
                throw new Exception($"The user with id {command.UserId} does not exist");
            }
            bool carExist = await _unitOfWork.CarRepository.ExistAsync((int)command.CarId!, cancel);
            if (!carExist)
            {
                throw new Exception($"The car with id {command.CarId} does not exist");
            }
        }

        public async Task<InsuranceViewModel> Handle(CreateInsuranceCommand command, CancellationToken cancel)
        {
            await ValidateInput(command, cancel);            
            Insurance insurance = new Insurance()
            {
                UserId = command.UserId,
                CarId = command.CarId,
                StartDate = command.StartDate,
                EndDate = command.EndDate,
                TypeOfInsurance = command.TypeOfInsurance,
                Premium = command.Premium,
                Status = command.Status
            };
            Insurance? result = await _unitOfWork.InsuranceRepository.CreateAsync(insurance, cancel);
            if (result is null)
            {
                throw new Exception("Error creating a new insurance");
            }
            return _mapper.Map<InsuranceViewModel>(result);
        }
    }
}
