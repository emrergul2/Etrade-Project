
using AutoMapper;
using ETrade.Core.DTOs;
using ETrade.Core.Modals;

namespace ETrade.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}