using InsuranceWebApplication.Dtos;
using MediatR;

namespace InsuranceWebApplication.CQRS.Cars.Query.GetCarList
{
    public class GetCarListQuery : IRequest<CarListResultDto>
    {
        public string? Keyword { get; set; }
        public bool GetAll { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
