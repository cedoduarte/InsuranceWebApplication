using InsuranceWebApplication.CQRS.Users.Command.CreateUser;
using InsuranceWebApplication.CQRS.Users.Command.DeleteUser;
using InsuranceWebApplication.CQRS.Users.Command.UpdateUser;
using InsuranceWebApplication.CQRS.Users.Query.GetUserById;
using InsuranceWebApplication.CQRS.Users.Query.GetUserList;
using InsuranceWebApplication.CQRS.Users.ViewModel;
using InsuranceWebApplication.Dtos;
using MediatR;

namespace InsuranceWebApplication.Services
{
    public interface IUserService
    {
        Task<UserViewModel?> CreateAsync(CreateUserCommand command);
        Task<UserViewModel?> UpdateAsync(UpdateUserCommand command);
        Task<UserViewModel?> DeleteAsync(int id);
        Task<UserViewModel?> GetByIdAsync(int id);
        Task<UserListResultDto> GetListAsync(GetUserListQuery query);
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
            return await _mediator.Send(query);
        }
    }
}
