using InsuranceWebApplication.CQRS.Cars.Command.CreateCar;
using InsuranceWebApplication.CQRS.Cars.Command.DeleteCar;
using InsuranceWebApplication.CQRS.Cars.Command.UpdateCar;
using InsuranceWebApplication.CQRS.Cars.Query.GetCarById;
using InsuranceWebApplication.CQRS.Cars.Query.GetCarList;
using InsuranceWebApplication.CQRS.Cars.ViewModel;
using InsuranceWebApplication.Dtos;
using MediatR;
using Microsoft.Extensions.Caching.Memory;

namespace InsuranceWebApplication.Services
{
    public interface ICarService
    {
        Task<CarViewModel?> CreateAsync(CreateCarCommand command);
        Task<CarViewModel?> UpdateAsync(UpdateCarCommand command);
        Task<CarViewModel?> DeleteAsync(int id);
        Task<CarViewModel?> GetByIdAsync(int id);
        Task<CarListResultDto> GetListAsync(GetCarListQuery query);
    }

    public class CarService : ICarService
    {
        private readonly IMediator _mediator;
        private readonly IMemoryCache _memoryCache;

        public CarService(IMediator mediator, IMemoryCache memoryCache)
        {
            _mediator = mediator;
            _memoryCache = memoryCache;
        }

        public async Task<CarViewModel?> CreateAsync(CreateCarCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<CarViewModel?> UpdateAsync(UpdateCarCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<CarViewModel?> DeleteAsync(int id)
        {
            return await _mediator.Send(new DeleteCarCommand() { Id = id });
        }

        public async Task<CarViewModel?> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetCarByIdQuery() { Id = id });
        }

        public async Task<CarListResultDto> GetListAsync(GetCarListQuery query)
        {
            CarListResultDto result;
            string cacheKey = $"CarsCacheKey{query.PageNumber}";
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
