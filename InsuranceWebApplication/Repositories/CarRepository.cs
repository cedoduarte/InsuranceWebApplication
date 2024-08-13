using InsuranceWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace InsuranceWebApplication.Repositories
{
    public interface ICarRepository
    {
        Task<Car?> CreateAsync(Car car, CancellationToken cancel = default);
        Task<Car?> UpdateAsync(Car car, CancellationToken cancel = default);
        Task<Car?> DeleteAsync(int id, CancellationToken cancel = default);
        Task<Car?> GetByIdAsync(int id, CancellationToken cancel = default);
        Task<List<Car>> GetAllAsync(int pageNumber = 1, int pageSize = 10, CancellationToken cancel = default);
        Task<List<Car>> GetByKeywordAsync(string keyword, int pageNumber = 1, int pageSize = 10, CancellationToken cancel = default);
        Task<bool> ExistAsync(int id, CancellationToken cancel = default);
        Task<int> CountAsync(CancellationToken cancel = default);
    }

    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _dbContext;

        public CarRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Car?> CreateAsync(Car car, CancellationToken cancel)
        {
            var createdCar = await _dbContext.AddAsync(car, cancel);
            await _dbContext.SaveChangesAsync(cancel);
            return createdCar.Entity;
        }

        public async Task<Car?> UpdateAsync(Car car, CancellationToken cancel)
        {
            var updatedCar = _dbContext.Update(car);
            await _dbContext.SaveChangesAsync(cancel);
            return updatedCar.Entity;
        }

        public async Task<Car?> DeleteAsync(int id, CancellationToken cancel)
        {
            Car? car = await _dbContext.Cars!
                .Where(c => c.Id == id && !c.IsDeleted)
                .FirstOrDefaultAsync(cancel);
            if (car is null)
            {
                throw new Exception($"The car with Id {id} does not exist");
            }
            car.IsDeleted = true;
            return await UpdateAsync(car, cancel);
        }

        public async Task<Car?> GetByIdAsync(int id, CancellationToken cancel) 
        {
            return await _dbContext.Cars!
                .Where(c => c.Id == id && !c.IsDeleted)
                .AsNoTracking()
                .FirstOrDefaultAsync(cancel);
        }

        public async Task<List<Car>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancel)
        {
            return await _dbContext.Cars!
                .Where(c => !c.IsDeleted)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync(cancel);
        }

        public async Task<List<Car>> GetByKeywordAsync(string keyword, int pageNumber, int pageSize, CancellationToken cancel)
        {
            return await _dbContext.Cars!
                .Where(c => !c.IsDeleted
                    && (Convert.ToString(c.Id).Contains(keyword)
                    || c.Model!.Contains(keyword)
                    || c.Color!.Contains(keyword)
                    || c.Price!.ToString()!.Contains(keyword)
                    || c.PlateNumber!.Contains(keyword)))
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync(cancel);
        }

        public async Task<bool> ExistAsync(int id, CancellationToken cancel)
        {
            Car? car = await _dbContext.Cars!.FindAsync(id, cancel);
            return car is not null;
        }

        public async Task<int> CountAsync(CancellationToken cancel)
        {
            return await _dbContext.Users!.CountAsync(cancel);
        }
    }
}