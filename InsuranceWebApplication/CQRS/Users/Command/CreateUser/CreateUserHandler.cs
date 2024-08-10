using AutoMapper;
using InsuranceWebApplication.CQRS.Users.Validators;
using InsuranceWebApplication.CQRS.Users.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using InsuranceWebApplication.Utils;
using MediatR;
using System.Text;

namespace InsuranceWebApplication.CQRS.Users.Command.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserViewModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly ICreateUserCommandValidator _validator;

        public CreateUserHandler(
            IUserRepository userRepository, 
            IMapper mapper, 
            ICreateUserCommandValidator validator)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<UserViewModel> Handle(CreateUserCommand command, CancellationToken cancel)
        {
            try
            {
                _validator.Validate(command);
                if (_validator.Errors.Count > 0)
                {
                    StringBuilder builder = new StringBuilder();
                    foreach (string error in _validator.Errors)
                    {
                        builder.AppendLine(error);
                    }
                    throw new Exception(builder.ToString());
                }
                User user = new User()
                {
                    FirstName = command.FirstName,
                    LastName = command.LastName,
                    Email = command.Email,
                    PasswordHash = Util.ToSha256(command.Password!)
                };
                User? result = await _userRepository.CreateAsync(user, cancel);
                if (result is null)
                {
                    throw new Exception("Error creating a new user!");
                }
                return _mapper.Map<UserViewModel>(result);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
