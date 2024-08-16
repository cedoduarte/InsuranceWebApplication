using InsuranceWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace InsuranceWebApplication.Services
{
    public interface IVisitCountService
    {
        Task<int> GetCountAsync(CancellationToken cancel = default);
        Task<int> IncrementCountAsync(CancellationToken cancel = default);
    }

    public class VisitCountService : IVisitCountService
    {
        private readonly AppDbContext _dbContext;

        public VisitCountService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> GetCountAsync(CancellationToken cancel)
        {
            int count = 0;
            var visitCount = await _dbContext.VisitCount!
                .AsNoTracking()
                .FirstOrDefaultAsync(cancel);
            if (visitCount is not null)
            {
                count = visitCount.Count;
            }
            return count;
        }

        public async Task<int> IncrementCountAsync(CancellationToken cancel)
        {
            var entity = await _dbContext.VisitCount!.FirstOrDefaultAsync(cancel);
            if (entity is null)
            {
                entity = new VisitCount()
                {
                    Count = 1
                };
                await _dbContext.AddAsync(entity);
            }
            else
            {
                entity.Count++;
                _dbContext.Update(entity);                
            }
            await _dbContext.SaveChangesAsync();
            return entity.Count;
        }
    }
}
