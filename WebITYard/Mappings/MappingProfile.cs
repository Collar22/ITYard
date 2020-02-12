using AutoMapper;

namespace WebITYard.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ViewModels.Customer, Services.Models.Customer>()
                .ForMember(d => d.FirstName, s => s.MapFrom(i => i.Name));
            CreateMap<Services.Models.Customer, ViewModels.Customer>()
                .ForMember(d => d.Name, s => s.MapFrom(i => i.FirstName));

            CreateMap<Services.Models.Customer, Repositories.Models.Customer>().ReverseMap();
            CreateMap<Services.Models.Order, ViewModels.Order>().ReverseMap();
            CreateMap<Services.Models.OrderItem, ViewModels.OrderItem>().ReverseMap();
        }
    }
}
