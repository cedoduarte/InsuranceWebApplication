using InsuranceWebApplication.CQRS.Users.ViewModel;

namespace InsuranceWebApplication.Dtos
{
    public class UserAuthenticationResultDto
    {
        public bool IsAuthenticated { get; set; }
        public string? ErrorMessage { get; set; }
        public UserViewModel? AuthenticatedUser { get; set; }
    }
}
