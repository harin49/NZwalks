using AutoMapper;
using NZwalks.DTO;
using NZwalks.Models;

namespace NZwalks.Mappers
{
    public class RegionsMapper : Profile
    {

        public RegionsMapper()
        {
            CreateMap<Region, RegionsResponseDTO>().ForMember(x => x.RegionsImageUrl, options => options.MapFrom(x => x.RegionImageUrl)).ReverseMap();
            CreateMap<RegionsRequestDTO, Region>().ForMember(x => x.RegionImageUrl, options => options.MapFrom(x => x.RegionsImageUrl ?? ""));
        }
    }
}
