using InsuranceWebApplication.CQRS.Users.ViewModel;
using MediatR;

namespace InsuranceWebApplication.CQRS.Users.Command.CreateUser
{
    public class CreateUserCommand : IRequest<UserViewModel>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmedPassword { get; set; }
    }
}
