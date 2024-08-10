using InsuranceWebApplication.CQRS.Users.ViewModel;
using MediatR;

namespace InsuranceWebApplication.CQRS.Users.Command.DeleteUser
{
    public class DeleteUserCommand : IRequest<UserViewModel>
    {
        public int Id { get; set; }
    }
}
