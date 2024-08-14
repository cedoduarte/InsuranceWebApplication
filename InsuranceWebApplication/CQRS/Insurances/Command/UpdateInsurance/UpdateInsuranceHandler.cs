using AutoMapper;
using InsuranceWebApplication.CQRS.Insurances.Validators;
using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;
using System.Text;

namespace InsuranceWebApplication.CQRS.Insurances.Command.UpdateInsurance
{
    public class UpdateInsuranceHandler : IRequestHandler<UpdateInsuranceCommand, InsuranceViewModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IUpdateInsuranceCommandValidator _validator;

        public UpdateInsuranceHandler(
            IUnitOfWork unitOfWork, 
            IMapper mapper, 
            IUpdateInsuranceCommandValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<InsuranceViewModel> Handle(UpdateInsuranceCommand command, CancellationToken cancel)
        {
            _validator.Validate(command);
            if (_validator.Errors.Any())
            {
                StringBuilder builder = new StringBuilder();
                foreach (string error in _validator.Errors)
                {
                    builder.AppendLine($"{error}</br>");
                }
                throw new Exception(builder.ToString());
            }
            Insurance? insurance = await _unitOfWork.InsuranceRepository.GetByIdAsync(command.Id, cancel);
            if (insurance is null)
            {
                throw new Exception($"The insurance with Id {command.Id} does not exist");
            }
            insurance.UserId = command.UserId;
            insurance.CarId = command.CarId;
            insurance.StartDate = command.StartDate;
            insurance.EndDate = command.EndDate;
            insurance.TypeOfInsurance = command.TypeOfInsurance!.Trim();
            insurance.Premium = command.Premium;
            insurance.Status = command.Status;
            insurance.LastModified = DateTime.UtcNow;
            Insurance? updatedInsurance = await _unitOfWork.InsuranceRepository.UpdateAsync(insurance, cancel);
            if (updatedInsurance is null)
            {
                throw new Exception("Error updating the insurance");
            }
            return _mapper.Map<InsuranceViewModel>(updatedInsurance);
        }
    }
}
