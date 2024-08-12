using InsuranceWebApplication.CQRS.Insurances.Command.CreateInsurance;

namespace InsuranceWebApplication.CQRS.Insurances.Validators
{
    public interface ICreateInsuranceCommandValidator
    {
        List<string> Errors { get; }
        void Validate(CreateInsuranceCommand command);
    }

    public class CreateInsuranceCommandValidator : ICreateInsuranceCommandValidator
    {
        public List<string> Errors { get; } = new();

        public void Validate(CreateInsuranceCommand command)
        {
            if (command.UserId is null)
            {
                Errors.Add("The user id is null");
            }
            if (command.CarId is null)
            {
                Errors.Add("The car id is null");
            }
            if (command.StartDate is null)
            {
                Errors.Add("The start date is null");
            }
            if (command.EndDate is null)
            {
                Errors.Add("The end date is null");
            }
            if (command.StartDate > command.EndDate)
            {
                Errors.Add("The start date cannot be later than end date");
            }
            if (string.IsNullOrEmpty(command.TypeOfInsurance))
            {
                Errors.Add("The type of insurance is empty");
            }
            if (command.Premium is null)
            {
                Errors.Add("The premium is null");
            }
            else if (command.Premium <= 0.0m)
            {
                Errors.Add("The premium needs to be greater than zero");
            }
            if (command.Status is null)
            {
                Errors.Add("The status is null");
            }
        }
    }
}
