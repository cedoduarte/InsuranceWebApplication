using InsuranceWebApplication.CQRS.Users.ViewModel;
using MediatR;

namespace InsuranceWebApplication.CQRS.Users.Query.GetUserById
{
    public class GetUserByIdQuery : IRequest<UserViewModel>
    {
        public int Id { get; set; }
    }
}
