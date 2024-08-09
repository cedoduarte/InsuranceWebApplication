using InsuranceWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace InsuranceWebApplication.Repositories
{
    public interface IUserRepository
    {
        Task<User?> CreateAsync(User user);
        Task<User?> UpdateAsync(User user);
        Task DeleteAsync(int id);
        Task<User?> GetByIdAsync(int id);
        Task<List<User>> GetAllAsync();
        Task<User?> GetByNameAsync(string name);
    }

    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User?> CreateAsync(User user)
        {
            var createdUser = await _dbContext.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return createdUser.Entity;
        }

        public async Task<User?> UpdateAsync(User user)
        {
            var updatedUser = _dbContext.Update(user);
            await _dbContext.SaveChangesAsync();
            return updatedUser.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            User? user = await _dbContext.Users!
                .Where(u => u.Id == id)
                .FirstOrDefaultAsync();
            if (user is null)
            {
                return;
            }
            user.IsDeleted = true;
            await UpdateAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            User? user = await _dbContext.Users!
                .Where(u => u.Id == id)
                .FirstOrDefaultAsync();
            return user;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _dbContext.Users!.ToListAsync();
        }

        public async Task<User?> GetByNameAsync(string name)
        {
            User? user = await _dbContext.Users!
                .Where(u => $"{u.FirstName} {u.LastName}".ToLower().Contains(name.ToLower()))
                .FirstOrDefaultAsync();
            return user;
        }
    }
}
