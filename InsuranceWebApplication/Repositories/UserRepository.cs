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
        Task<List<User>> GetAllAsync(int pageNumber = 1, int pageSize = 10, CancellationToken cancel = default);
        Task<List<User>> GetByKeywordAsync(string keyword, int pageNumber = 1, int pageSize = 10, CancellationToken cancel = default);
        Task<bool> ExistAsync(int id, CancellationToken cancel = default);
        Task<int> CountAsync(CancellationToken cancel = default);
        Task<bool> AuthenticateAsync(string email, string passwordHash, CancellationToken cancel = default);
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
            User? user = await _dbContext.Users!
                .Where(u => u.Id == id && !u.IsDeleted)
                .FirstOrDefaultAsync(cancel);
            if (user is null)
            {
                throw new Exception($"The user with Id {id} does not exist");
            }
            user.IsDeleted = true;
            return await UpdateAsync(user, cancel);
        }

        public async Task<User?> GetByIdAsync(int id, CancellationToken cancel)
        {
            return await _dbContext.Users!
                .Where(u => u.Id == id && !u.IsDeleted)
                .AsNoTracking()
                .FirstOrDefaultAsync(cancel);
        }

        public async Task<List<User>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancel)
        {
            return await _dbContext.Users!
                .Where(u => !u.IsDeleted)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync(cancel);
        }

        public async Task<List<User>> GetByKeywordAsync(string keyword, int pageNumber, int pageSize, CancellationToken cancel)
        {
            return await _dbContext.Users!
                .Where(u => !u.IsDeleted 
                    && (Convert.ToString(u.Id).Contains(keyword)
                    || u.FirstName!.Contains(keyword)
                    || u.LastName!.Contains(keyword)
                    || u.Email!.Contains(keyword)))
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync(cancel);
        }

        public async Task<bool> ExistAsync(int id, CancellationToken cancel)
        {
            User? user = await _dbContext.Users!.FindAsync(id, cancel);
            return user is not null;
        }

        public async Task<int> CountAsync(CancellationToken cancel)
        {
            return await _dbContext.Users!.CountAsync(cancel);
        }

        public async Task<bool> AuthenticateAsync(string email, string passwordHash, CancellationToken cancel)
        {
            User? user = await _dbContext.Users!
                .Where(
                    u => !u.IsDeleted
                    && string.Equals(u.Email, email)
                    && string.Equals(u.PasswordHash, passwordHash))
                .AsNoTracking()
                .FirstOrDefaultAsync(cancel);
            return user is not null;
        }
    }
}
