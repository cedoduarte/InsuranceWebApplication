using InsuranceWebApplication.CQRS.Users.ViewModel;

namespace InsuranceWebApplication.Dtos
{
    public class UserListResultDto
    {
        public int TotalCount { get; set; }
        public List<UserViewModel>? UserList { get; set; }
    }
}
