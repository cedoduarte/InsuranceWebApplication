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
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICreateUserCommandValidator _validator;

        public CreateUserHandler(
            IUnitOfWork unitOfWork, 
            IMapper mapper, 
            ICreateUserCommandValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<UserViewModel> Handle(CreateUserCommand command, CancellationToken cancel)
        {
            _validator.Validate(command);
            if (_validator.Errors.Any())
            {
                StringBuilder builder = new StringBuilder();
                foreach (string error in _validator.Errors)
                {
                    builder.AppendLine($"{error}</br>");
                }
                throw new Exception(builder.ToString());
            }
            User user = new User()
            {
                FirstName = command.FirstName!.Trim(),
                LastName = command.LastName!.Trim(),
                Email = command.Email!.Trim(),
                PasswordHash = Util.ToSha256(command.Password!.Trim()!)
            };
            User? result = await _unitOfWork.UserRepository.CreateAsync(user, cancel);
            if (result is null)
            {
                throw new Exception("Error creating a new user!");
            }
            return _mapper.Map<UserViewModel>(result);
        }
    }
}
