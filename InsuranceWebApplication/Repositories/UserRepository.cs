using InsuranceWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace InsuranceWebApplication.Repositories
{
    public interface IUserRepository
    {
        Task<User?> CreateAsync(User user, CancellationToken cancel = default);
        Task<User?> UpdateAsync(User user, CancellationToken cancel = default);
        Task DeleteAsync(int id, CancellationToken cancel = default);
        Task<User?> GetByIdAsync(int id, CancellationToken cancel = default);
        Task<List<User>> GetAllAsync(CancellationToken cancel = default);
        Task<User?> GetByNameAsync(string name, CancellationToken cancel = default);
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

        public async Task DeleteAsync(int id, CancellationToken cancel)
        {
            User? user = await _dbContext.Users!
                    .Where(u => u.Id == id)
                    .FirstOrDefaultAsync(cancel);
            if (user is null)
            {
                return;
            }
            user.IsDeleted = true;
            await UpdateAsync(user, cancel);
            await _dbContext.SaveChangesAsync(cancel);
        }

        public async Task<User?> GetByIdAsync(int id, CancellationToken cancel)
        {
            User? user = await _dbContext.Users!.FindAsync(id, cancel);
            return user;
        }

        public async Task<List<User>> GetAllAsync(CancellationToken cancel)
        {
            return await _dbContext.Users!.ToListAsync(cancel);
        }

        public async Task<User?> GetByNameAsync(string name, CancellationToken cancel)
        {
            User? user = await _dbContext.Users!
                    .Where(u => $"{u.FirstName} {u.LastName}".ToLower().Contains(name.ToLower()))
                    .FirstOrDefaultAsync(cancel);
            return user;
        }
    }
}
