using InsuranceWebApplication.CQRS.Insurances.Command.CreateInsurance;
using InsuranceWebApplication.CQRS.Insurances.Command.DeleteInsurance;
using InsuranceWebApplication.CQRS.Insurances.Command.UpdateInsurance;
using InsuranceWebApplication.CQRS.Insurances.Query.GetInsuranceById;
using InsuranceWebApplication.CQRS.Insurances.Query.GetInsuranceList;
using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using InsuranceWebApplication.Dtos;
using MediatR;
using Microsoft.Extensions.Caching.Memory;

namespace InsuranceWebApplication.Services
{
    public interface IInsuranceService
    {
        Task<InsuranceViewModel?> CreateAsync(CreateInsuranceCommand command);
        Task<InsuranceViewModel?> UpdateAsync(UpdateInsuranceCommand command);
        Task<InsuranceViewModel?> DeleteAsync(int id);
        Task<InsuranceViewModel?> GetByIdAsync(int id);
        Task<InsuranceListResultDto> GetListAsync(GetInsuranceListQuery query);
    }

    public class InsuranceService : IInsuranceService
    {
        private readonly IMediator _mediator;
        private readonly IMemoryCache _memoryCache;

        public InsuranceService(IMediator mediator, IMemoryCache memoryCache)
        {
            _mediator = mediator;
            _memoryCache = memoryCache;
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
            return await _mediator.Send(new DeleteInsuranceCommand() { Id = id });
        }

        public async Task<InsuranceViewModel?> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetInsuranceByIdQuery() { Id = id });
        }

        public async Task<InsuranceListResultDto> GetListAsync(GetInsuranceListQuery query)
        {
            InsuranceListResultDto result;
            string cacheKey = $"InsurancesCacheKey{query.PageNumber}";
            if (!_memoryCache.TryGetValue(cacheKey, out result!))
            {
                result = await _mediator.Send(query);
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(2))
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));
                _memoryCache.Set(cacheKey, result, cacheEntryOptions);
            }
            return result;
        }
    }
}
