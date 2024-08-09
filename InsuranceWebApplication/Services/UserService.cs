using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;

namespace InsuranceWebApplication.Services
{
    public interface IUserService
    {
        Task<User?> CreateAsync(User user);
        Task<User?> UpdateAsync(User user);
        Task DeleteAsync(int id);
        Task<User?> GetByIdAsync(int id);
        Task<List<User>> GetAllAsync();
        Task<User?> GetByNameAsync(string name);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<User?> CreateAsync(User user)
        {
            return await _repository.CreateAsync(user);
        }

        public async Task<User?> UpdateAsync(User user)
        {
            return await _repository.UpdateAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<User?> GetByNameAsync(string name)
        {
            return await _repository.GetByNameAsync(name);
        }
    }
}
