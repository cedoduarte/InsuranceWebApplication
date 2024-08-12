using InsuranceWebApplication.CQRS.Insurances.Command.CreateInsurance;
using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using MediatR;

namespace InsuranceWebApplication.Services
{
    public interface IInsuranceService
    {
        Task<InsuranceViewModel?> CreateAsync(CreateInsuranceCommand command);
    }

    public class InsuranceService : IInsuranceService
    {
        private readonly IMediator _mediator;

        public InsuranceService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<InsuranceViewModel?> CreateAsync(CreateInsuranceCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
