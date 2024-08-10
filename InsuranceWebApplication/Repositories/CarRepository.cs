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
        Task<List<Car>> GetAllAsync(CancellationToken cancel = default);
        Task<List<Car>> GetByKeyword(string keyword, CancellationToken cancel = default);
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
            Car? car = await GetByIdAsync(id, cancel);
            if (car is null)
            {
                return null;
            }
            car.IsDeleted = true;
            await UpdateAsync(car, cancel);
            await _dbContext.SaveChangesAsync(cancel);
            return car;
        }

        public async Task<Car?> GetByIdAsync(int id, CancellationToken cancel) 
        {
            return await _dbContext.Cars!
                .Where(c => c.Id == id && !c.IsDeleted)
                .FirstOrDefaultAsync(cancel);
        }

        public async Task<List<Car>> GetAllAsync(CancellationToken cancel)
        {
            return await _dbContext.Cars!
                .Where(c => !c.IsDeleted)
                .ToListAsync(cancel);
        }

        public async Task<List<Car>> GetByKeyword(string keyword, CancellationToken cancel)
        {
            return await _dbContext.Cars!
                .Where(u => !u.IsDeleted
                    && (Convert.ToString(u.Id).Contains(keyword)
                    || u.Model!.Contains(keyword)
                    || u.Color!.Contains(keyword)
                    || Convert.ToString(u.Price).Contains(keyword)
                    || u.PlateNumber!.Contains(keyword)))
                .ToListAsync(cancel);
        }
    }
}