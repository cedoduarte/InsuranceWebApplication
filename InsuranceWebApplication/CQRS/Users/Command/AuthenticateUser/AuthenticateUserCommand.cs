using InsuranceWebApplication.Dtos;
using MediatR;

namespace InsuranceWebApplication.CQRS.Users.Command.AuthenticateUser
{
    public class AuthenticateUserCommand : IRequest<UserAuthenticationResultDto>
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
