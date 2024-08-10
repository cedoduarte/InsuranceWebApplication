using InsuranceWebApplication.CQRS.Cars.ViewModel;
using MediatR;

namespace InsuranceWebApplication.CQRS.Cars.Command.CreateCar
{
    public class CreateCarCommand : IRequest<CarViewModel>
    {
        public string? Model { get; set; }
        public string? Color { get; set; }
        public decimal? Price { get; set; }
        public string? PlateNumber { get; set; }
    }
}
