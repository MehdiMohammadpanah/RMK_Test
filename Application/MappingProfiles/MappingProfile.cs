
using Application.DTOs;
using AutoMapper;
using Domain.PersonDetails;

namespace Application.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Person, PersonDto>().ReverseMap();
            CreateMap<Person, PersonDto>();
            CreateMap<Person, PersonWithAddressDto>();
            CreateMap<Address, AddressDto>();
        }
    }
}
