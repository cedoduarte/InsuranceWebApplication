using AutoMapper;
using InsuranceWebApplication.CQRS.Users.Validators;
using InsuranceWebApplication.CQRS.Users.ViewModel;
using InsuranceWebApplication.Models;
using InsuranceWebApplication.Repositories;
using InsuranceWebApplication.Utils;
using MediatR;
using System.Text;

namespace InsuranceWebApplication.CQRS.Users.Command.UpdateUser
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, UserViewModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IUpdateUserCommandValidator _validator;
        
        public UpdateUserHandler(
            IUserRepository userRepository, 
            IMapper mapper, 
            IUpdateUserCommandValidator validator)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<UserViewModel> Handle(UpdateUserCommand command, CancellationToken cancel)
        {
            _validator.Validate(command);
            if (_validator.Errors.Any())
            {
                StringBuilder builder = new StringBuilder();
                foreach (string error in _validator.Errors)
                {
                    builder.AppendLine(error);
                }
                throw new Exception(builder.ToString());
            }
            User? user = await _userRepository.GetByIdAsync(command.Id, cancel);
            if (user is null)
            {
                throw new Exception($"The user with Id {command.Id} does not exist");
            }
            user.FirstName = command.FirstName!.Trim();
            user.LastName = command.LastName!.Trim();
            user.Email = command.Email!.Trim();
            user.PasswordHash = Util.ToSha256(command.Password!.Trim());
            User? updatedUser = await _userRepository.UpdateAsync(user, cancel);
            if (updatedUser is null)
            {
                throw new Exception("Error updating the user");
            }
            return _mapper.Map<UserViewModel>(updatedUser);
        }
    }
}
