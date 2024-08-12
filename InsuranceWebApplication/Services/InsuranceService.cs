using InsuranceWebApplication.CQRS.Insurances.Command.CreateInsurance;
using InsuranceWebApplication.CQRS.Insurances.Command.DeleteInsurance;
using InsuranceWebApplication.CQRS.Insurances.Command.UpdateInsurance;
using InsuranceWebApplication.CQRS.Insurances.Query.GetInsuranceById;
using InsuranceWebApplication.CQRS.Insurances.Query.GetInsuranceList;
using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using MediatR;

namespace InsuranceWebApplication.Services
{
    public interface IInsuranceService
    {
        Task<InsuranceViewModel?> CreateAsync(CreateInsuranceCommand command);
        Task<InsuranceViewModel?> UpdateAsync(UpdateInsuranceCommand command);
        Task<InsuranceViewModel?> DeleteAsync(int id);
        Task<InsuranceViewModel?> GetByIdAsync(int id);
        Task<List<InsuranceViewModel>> GetListAsync(GetInsuranceListQuery query);
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

        public async Task<InsuranceViewModel?> UpdateAsync(UpdateInsuranceCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<InsuranceViewModel?> DeleteAsync(int id)
        {
            return await _mediator.Send(new DeleteInsuranceCommand()
            {
                Id = id
            });
        }

        public async Task<InsuranceViewModel?> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetInsuranceByIdQuery() 
            {
                Id = id
            });
        }

        public async Task<List<InsuranceViewModel>> GetListAsync(GetInsuranceListQuery query)
        {
            return await _mediator.Send(query);
        }
    }
}
