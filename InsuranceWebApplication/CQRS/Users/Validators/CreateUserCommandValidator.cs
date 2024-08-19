using InsuranceWebApplication.CQRS.Users.Command.CreateUser;
using InsuranceWebApplication.Utils;

namespace InsuranceWebApplication.CQRS.Users.Validators
{
    public interface ICreateUserCommandValidator
    {
        List<string> Errors { get; }
        void Validate(CreateUserCommand command);
    }

    public class CreateUserCommandValidator : ICreateUserCommandValidator
    {
        public List<string> Errors { get; } = new();

        public void Validate(CreateUserCommand command)
        {
            if (string.IsNullOrEmpty(command.FirstName))
            {
                Errors.Add("The first name is empty");
            }
            if (string.IsNullOrEmpty(command.LastName))
            {
                Errors.Add("The last name is empty");
            }
            if (string.IsNullOrEmpty(command.Email))
            {
                Errors.Add("The email is empty");
            }
            else if (!Util.IsValidEmail(command.Email))
            {
                Errors.Add($"Invalid email: {command.Email}");
            }
            if (string.IsNullOrEmpty(command.Password))
            {
                Errors.Add("The password is empty");
            }
            if (!Util.IsPasswordSecure(command.Password!))
            {
                Errors.Add("The password is insecure");
            }
            if (string.IsNullOrEmpty(command.ConfirmedPassword))
            {
                Errors.Add("The confirmed password is empty");
            }
            else if (!string.Equals(command.Password, command.ConfirmedPassword, StringComparison.Ordinal))
            {
                Errors.Add("The password needs to be confirmed correctly");
            }
        }
    }
}
