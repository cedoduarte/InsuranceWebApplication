using InsuranceWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace InsuranceWebApplication.Repositories
{
    public interface IInsuranceRepository
    {
        Task<Insurance?> CreateAsync(Insurance insurance, CancellationToken cancel = default);
        Task<Insurance?> UpdateAsync(Insurance insurance, CancellationToken cancel = default);
        Task<Insurance?> DeleteAsync(int id, CancellationToken cancel = default);
        Task<Insurance?> GetByIdAsync(int id, CancellationToken cancel = default);
        Task<List<Insurance>> GetAllAsync(CancellationToken cancel = default);
        Task<List<Insurance>> GetByKeywordAsync(string keyword, CancellationToken cancel = default);
        Task<bool> ExistAsync(int id, CancellationToken cancel = default);
    }

    public class InsuranceRepository : IInsuranceRepository
    {
        private readonly AppDbContext _dbContext;

        public InsuranceRepository(AppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<Insurance?> CreateAsync(Insurance insurance, CancellationToken cancel)
        {
            var createdInsurance = await _dbContext.AddAsync(insurance, cancel);
            await _dbContext.SaveChangesAsync(cancel);
            return createdInsurance.Entity;
        }

        public async Task<Insurance?> UpdateAsync(Insurance insurance, CancellationToken cancel)
        {
            var updatedInsurance = _dbContext.Update(insurance);
            await _dbContext.SaveChangesAsync(cancel);
            return updatedInsurance.Entity;
        }

        public async Task<Insurance?> DeleteAsync(int id, CancellationToken cancel)
        {
            Insurance? insurance = await _dbContext.Insurances!
                .Where(i => i.Id == id && !i.IsDeleted)
                .FirstOrDefaultAsync(cancel);
            if (insurance is null)
            {
                throw new Exception($"The insurance with Id {id} does not exist");
            }
            insurance.IsDeleted = true;
            return await UpdateAsync(insurance, cancel);
        }

        public async Task<Insurance?> GetByIdAsync(int id, CancellationToken cancel)
        {
            return await _dbContext.Insurances!
                .Where(i => i.Id == id && !i.IsDeleted)
                .Include(i => i.Car)
                .Include(i => i.User)
                .AsNoTracking()
                .FirstOrDefaultAsync(cancel);
        }

        public async Task<List<Insurance>> GetAllAsync(CancellationToken cancel)
        {
            return await _dbContext.Insurances!
                .Where(i => !i.IsDeleted)
                .Include(i => i.Car)
                .Include(i => i.User)
                .AsNoTracking()
                .ToListAsync(cancel);
        }

        public async Task<List<Insurance>> GetByKeywordAsync(string keyword, CancellationToken cancel)
        {
            return await _dbContext.Insurances!
                .Where(i => !i.IsDeleted
                    && (Convert.ToString(i.Id).Contains(keyword)
                    || i.StartDate.ToString()!.Contains(keyword)
                    || i.EndDate.ToString()!.Contains(keyword)
                    || i.TypeOfInsurance!.Contains(keyword)
                    || i.Premium.ToString()!.Contains(keyword)
                    || i.User!.FirstName!.Contains(keyword)
                    || i.User!.LastName!.Contains(keyword)
                    || i.User!.Email!.Contains(keyword)
                    || i.Car!.Model!.Contains(keyword)
                    || i.Car!.Color!.Contains(keyword)
                    || i.Car.Price!.ToString()!.Contains(keyword)
                    || i.Car.PlateNumber!.Contains(keyword)))
                .Include(i => i.Car)
                .Include(i => i.User)
                .AsNoTracking()
                .ToListAsync(cancel);
        }

        public async Task<bool> ExistAsync(int id, CancellationToken cancel)
        {
            Insurance? insurance = await _dbContext.Insurances!.FindAsync(id, cancel);
            return insurance is not null;
        }
    }
}
