using InsuranceWebApplication.CQRS.Users.ViewModel;
using MediatR;

namespace InsuranceWebApplication.CQRS.Users.Query.GetUserList
{
    public class GetUserListQuery : IRequest<List<UserViewModel>>
    {
        public string? Keyword { get; set; }
        public bool GetAll { get; set; }
    }
}
