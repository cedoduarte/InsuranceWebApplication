using AutoMapper;
using InsuranceWebApplication.CQRS.Users.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using MediatR;

namespace InsuranceWebApplication.CQRS.Users.Command.DeleteUser
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, UserViewModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public DeleteUserHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserViewModel> Handle(DeleteUserCommand command, CancellationToken cancel)
        {
            User? result = await _userRepository.DeleteAsync(command.Id, cancel);
            return _mapper.Map<UserViewModel>(result);
        }
    }
}
