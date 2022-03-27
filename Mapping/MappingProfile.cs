using AutoMapper;
using vega.Controllers.Resources;
using vega.Models;

namespace vega.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain To Resource(DTO)
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}