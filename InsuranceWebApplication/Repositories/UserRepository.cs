using InsuranceWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace InsuranceWebApplication.Repositories
{
    public interface IUserRepository
    {
        Task<User?> CreateAsync(User user, CancellationToken cancel = default);
        Task<User?> UpdateAsync(User user, CancellationToken cancel = default);
        Task<User?> DeleteAsync(int id, CancellationToken cancel = default);
        Task<User?> GetByIdAsync(int id, CancellationToken cancel = default);
        Task<List<User>> GetAllAsync(CancellationToken cancel = default);
        Task<List<User>> GetByKeyword(string keyword, CancellationToken cancel = default);
    }

    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User?> CreateAsync(User user, CancellationToken cancel)
        {
            var createdUser = await _dbContext.AddAsync(user, cancel);
            await _dbContext.SaveChangesAsync(cancel);
            return createdUser.Entity;
        }

        public async Task<User?> UpdateAsync(User user, CancellationToken cancel)
        {
            var updatedUser = _dbContext.Update(user);
            await _dbContext.SaveChangesAsync(cancel);
            return updatedUser.Entity;
        }

        public async Task<User?> DeleteAsync(int id, CancellationToken cancel)
        {
            User? user = await GetByIdAsync(id, cancel);
            if (user is null)
            {
                throw new Exception($"The user with Id {id} does not exist");
            }
            user.IsDeleted = true;
            await UpdateAsync(user, cancel);
            await _dbContext.SaveChangesAsync(cancel);
            return user;
        }

        public async Task<User?> GetByIdAsync(int id, CancellationToken cancel)
        {
            return await _dbContext.Users!
                .Where(u => u.Id == id && !u.IsDeleted)
                .AsNoTracking()
                .FirstOrDefaultAsync(cancel);
        }

        public async Task<List<User>> GetAllAsync(CancellationToken cancel)
        {
            return await _dbContext.Users!
                .Where(u => !u.IsDeleted)
                .AsNoTracking()
                .ToListAsync(cancel);
        }

        public async Task<List<User>> GetByKeyword(string keyword, CancellationToken cancel)
        {
            return await _dbContext.Users!
                .Where(u => !u.IsDeleted 
                    && (Convert.ToString(u.Id).Contains(keyword)
                    || u.FirstName!.Contains(keyword)
                    || u.LastName!.Contains(keyword)
                    || u.Email!.Contains(keyword)))
                .AsNoTracking()
                .ToListAsync(cancel);
        }
    }
}
