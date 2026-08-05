using AutoMapper;
using Domain.Enum;
using Domain.Models;
using Domain.Services.DTO;
using Microsoft.AspNetCore.Identity.Data;



namespace Domain.Services.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Destination, DestinationDto>().ReverseMap();
            //CreateMap<Destination, DestinationResponseDto>().ReverseMap();


            CreateMap<AddUserDto, AuthUser>().ReverseMap();

            CreateMap<AuthUser, UserResponseDto>().ReverseMap();
        }
    }
}