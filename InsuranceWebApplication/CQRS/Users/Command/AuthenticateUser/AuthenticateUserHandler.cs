using InsuranceWebApplication.Dtos;
using InsuranceWebApplication.Repositories;
using InsuranceWebApplication.Utils;
using MediatR;

namespace InsuranceWebApplication.CQRS.Users.Command.AuthenticateUser
{
    public class AuthenticateUserHandler : IRequestHandler<AuthenticateUserCommand, UserAuthenticationResultDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthenticateUserHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<UserAuthenticationResultDto> Handle(AuthenticateUserCommand command, CancellationToken cancel)
        {
            if (string.IsNullOrEmpty(command.Email))
            {
                throw new Exception("The email is empty");
            }
            if (string.IsNullOrEmpty(command.Password))
            {
                throw new Exception("The password is empty");
            }
            string passwordHash = Util.ToSha256(command.Password);
            bool authenticated = await _unitOfWork.UserRepository.AuthenticateAsync(command.Email, passwordHash, cancel);
            return new UserAuthenticationResultDto()
            {
                IsAuthenticated = authenticated,
                ErrorMessage = authenticated ? "Authenticated successfully" : "The credentials are invalid"
            };
        }
    }
}
