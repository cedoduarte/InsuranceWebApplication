using InsuranceWebApplication.CQRS.Cars.ViewModel;
using MediatR;

namespace InsuranceWebApplication.CQRS.Cars.Command.UpdateCar
{
    public class UpdateCarCommand : IRequest<CarViewModel>
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public decimal? Price { get; set; }
        public string? PlateNumber { get; set; }
    }
}
