using InsuranceWebApplication.CQRS.Users.Command.CreateUser;
using InsuranceWebApplication.CQRS.Users.ViewModel;
using InsuranceWebApplication.Models;
using MediatR;

namespace InsuranceWebApplication.Services
{
    public interface IUserService
    {
        Task<UserViewModel?> CreateAsync(CreateUserCommand command);
        Task<User?> UpdateAsync(User user);
        Task DeleteAsync(int id);
        Task<User?> GetByIdAsync(int id);
        Task<List<User>> GetAllAsync();
        Task<User?> GetByNameAsync(string name);
    }

    public class UserService : IUserService
    {
        private readonly IMediator _mediator;

        public UserService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<UserViewModel?> CreateAsync(CreateUserCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<User?> UpdateAsync(User user)
        {
            throw new NotImplementedException();
            //return await _repository.UpdateAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
            //await _repository.DeleteAsync(id);
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
            // return await _repository.GetByIdAsync(id);
        }

        public async Task<List<User>> GetAllAsync()
        {
            throw new NotImplementedException();
            // return await _repository.GetAllAsync();
        }

        public async Task<User?> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
            // return await _repository.GetByNameAsync(name);
        }
    }
}
