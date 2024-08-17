using InsuranceWebApplication.CQRS.Users.Command.UpdateUser;
using InsuranceWebApplication.Utils;

namespace InsuranceWebApplication.CQRS.Users.Validators
{
    public interface IUpdateUserCommandValidator
    {
        List<string> Errors { get; }
        void Validate(UpdateUserCommand command);
    }

    public class UpdateUserCommandValidator : IUpdateUserCommandValidator
    {
        public List<string> Errors { get; } = new();

        public void Validate(UpdateUserCommand command)
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
