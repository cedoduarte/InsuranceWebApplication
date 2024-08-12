using AutoMapper;
using InsuranceWebApplication.CQRS.Cars.ViewModel;
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
        }
    }
}
