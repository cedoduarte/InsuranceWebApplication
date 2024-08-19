using InsuranceWebApplication.CQRS.Users.Command.AuthenticateUser;
using InsuranceWebApplication.CQRS.Users.Command.CreateUser;
using InsuranceWebApplication.CQRS.Users.Command.DeleteUser;
using InsuranceWebApplication.CQRS.Users.Command.UpdateUser;
using InsuranceWebApplication.CQRS.Users.Query.GetUserById;
using InsuranceWebApplication.CQRS.Users.Query.GetUserList;
using InsuranceWebApplication.CQRS.Users.ViewModel;
using InsuranceWebApplication.Dtos;
using MediatR;
using Microsoft.Extensions.Caching.Memory;

namespace InsuranceWebApplication.Services
{
    public interface IUserService
    {
        Task<UserViewModel?> CreateAsync(CreateUserCommand command);
        Task<UserViewModel?> UpdateAsync(UpdateUserCommand command);
        Task<UserViewModel?> DeleteAsync(int id);
        Task<UserViewModel?> GetByIdAsync(int id);
        Task<UserListResultDto> GetListAsync(GetUserListQuery query);
        Task<UserAuthenticationResultDto> AuthenticateAsync(AuthenticateUserCommand command);
    }

    public class UserService : IUserService
    {
        private readonly IMediator _mediator;
        private readonly IMemoryCache _memoryCache;

        public UserService(IMediator mediator, IMemoryCache memoryCache)
        {
            _mediator = mediator;
            _memoryCache = memoryCache;
        }

        public async Task<UserViewModel?> CreateAsync(CreateUserCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<UserViewModel?> UpdateAsync(UpdateUserCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<UserViewModel?> DeleteAsync(int id)
        {
            return await _mediator.Send(new DeleteUserCommand() { Id = id });
        }

        public async Task<UserViewModel?> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetUserByIdQuery() { Id = id });
        }     

        public async Task<UserListResultDto> GetListAsync(GetUserListQuery query)
        {
            UserListResultDto result;
            string cacheKey = $"UsersCacheKey{query.PageNumber}";
            if (!_memoryCache.TryGetValue(cacheKey, out result!))
            {
                result = await _mediator.Send(query);
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(2))
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));
                _memoryCache.Set(cacheKey, result, cacheEntryOptions);
            }
            return result;
        }

        public async Task<UserAuthenticationResultDto> AuthenticateAsync(AuthenticateUserCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
