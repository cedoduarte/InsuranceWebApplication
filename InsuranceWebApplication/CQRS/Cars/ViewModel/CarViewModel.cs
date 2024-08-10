namespace InsuranceWebApplication.CQRS.Cars.ViewModel
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public decimal Price { get; set; }
        public string? PlateNumber { get; set; }
    }
}
