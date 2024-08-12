using InsuranceWebApplication.CQRS.Cars.Command.UpdateCar;
using InsuranceWebApplication.Utils;

namespace InsuranceWebApplication.CQRS.Cars.Validators
{
    public interface IUpdateCarCommandValidator
    {
        List<string> Errors { get; }
        void Validate(UpdateCarCommand command);
    }

    public class UpdateCarCommandValidator : IUpdateCarCommandValidator
    {
        public List<string> Errors { get; } = new();

        public void Validate(UpdateCarCommand command)
        {
            if (string.IsNullOrEmpty(command.Model))
            {
                Errors.Add("The model is empty");
            }
            if (string.IsNullOrEmpty(command.Color))
            {
                Errors.Add("The color is empty");
            }
            else if (!Util.IsValidHexColor(command.Color))
            {
                Errors.Add($"Invalid color: {command.Color}");
            }
            if (command.Price is null)
            {
                Errors.Add("The price is null");
            }
            if (string.IsNullOrEmpty(command.PlateNumber))
            {
                Errors.Add("The plate number is empty");
            }
        }
    }
}
