using AutoMapper;
using NZwalks.DTO;
using NZwalks.Models;

namespace NZwalks.Mappers
{
    public class WalksMapper: Profile
    {

        public WalksMapper() { 
            CreateMap<Walks, WalksResponseDTO>().ReverseMap();
            CreateMap<WalksRequestDTO, Walks>().ReverseMap();
        }
    }
}
