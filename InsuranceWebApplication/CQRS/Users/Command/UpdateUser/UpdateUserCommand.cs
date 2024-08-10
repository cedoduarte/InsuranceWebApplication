using InsuranceWebApplication.CQRS.Users.ViewModel;
using MediatR;

namespace InsuranceWebApplication.CQRS.Users.Command.UpdateUser
{
    public class UpdateUserCommand : IRequest<UserViewModel>
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
