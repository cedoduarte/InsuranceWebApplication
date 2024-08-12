using AutoMapper;
using InsuranceWebApplication.CQRS.Cars.ViewModel;
using InsuranceWebApplication.CQRS.Insurances.ViewModel;
using InsuranceWebApplication.CQRS.Users.ViewModel;
using InsuranceWebApplication.Models;

namespace InsuranceWebApplication.AutoMapperProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.FirstName, b => b.MapFrom(c => c.FirstName))
                .ForMember(a => a.LastName, b => b.MapFrom(c => c.LastName))
                .ForMember(a => a.Email, b => b.MapFrom(c => c.Email))
                .ForMember(a => a.LastModified, b => b.MapFrom(c => c.LastModified))
                .ForMember(a => a.IsDeleted, b => b.MapFrom(c => c.IsDeleted))
                .ForMember(a => a.LastDeleted, b => b.MapFrom(c => c.LastDeleted))
                .ForMember(a => a.LastCreated, b => b.MapFrom(c => c.LastCreated));

        CreateMap<Car, CarViewModel>()
                .ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.Model, b => b.MapFrom(c => c.Model))
                .ForMember(a => a.Color, b => b.MapFrom(c => c.Color))
                .ForMember(a => a.Price, b => b.MapFrom(c => c.Price))
                .ForMember(a => a.PlateNumber, b => b.MapFrom(c => c.PlateNumber))
                .ForMember(a => a.LastModified, b => b.MapFrom(c => c.LastModified))
                .ForMember(a => a.IsDeleted, b => b.MapFrom(c => c.IsDeleted))
                .ForMember(a => a.LastDeleted, b => b.MapFrom(c => c.LastDeleted))
                .ForMember(a => a.LastCreated, b => b.MapFrom(c => c.LastCreated));

            CreateMap<Insurance, InsuranceViewModel>()
                .ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.StartDate, b => b.MapFrom(c => c.StartDate))
                .ForMember(a => a.EndDate, b => b.MapFrom(c => c.EndDate))
                .ForMember(a => a.TypeOfInsurance, b => b.MapFrom(c => c.TypeOfInsurance))
                .ForMember(a => a.Premium, b => b.MapFrom(c => c.Premium))
                .ForMember(a => a.Status, b => b.MapFrom(c => c.Status))
                .ForMember(a => a.UserId, b => b.MapFrom(c => c.UserId))
                .ForMember(a => a.FirstName, b => b.MapFrom(c => c.User!.FirstName))
                .ForMember(a => a.LastName, b => b.MapFrom(c => c.User!.LastName))
                .ForMember(a => a.Email, b => b.MapFrom(c => c.User!.Email))
                .ForMember(a => a.CarId, b => b.MapFrom(c => c.CarId))
                .ForMember(a => a.Model, b => b.MapFrom(c => c.Car!.Model))
                .ForMember(a => a.Color, b => b.MapFrom(c => c.Car!.Color))
                .ForMember(a => a.Price, b => b.MapFrom(c => c.Car!.Price))
                .ForMember(a => a.PlateNumber, b => b.MapFrom(c => c.Car!.PlateNumber))
                .ForMember(a => a.LastModified, b => b.MapFrom(c => c.LastModified))
                .ForMember(a => a.IsDeleted, b => b.MapFrom(c => c.IsDeleted))
                .ForMember(a => a.LastDeleted, b => b.MapFrom(c => c.LastDeleted))
                .ForMember(a => a.LastCreated, b => b.MapFrom(c => c.LastCreated));
        }
    }
}
